namespace Recording
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using DirectShowLib;
    using OpenCvSharp;
    using OpenCvSharp.Extensions;

    using Size = OpenCvSharp.Size;

    public class Camera : IDisposable
    {
        private readonly string _deviceName;
        private DsDevice _device;

        public int DeviceIndex { get; private set; }

        public Camera(string deviceName)
        {
            _deviceName = deviceName;
        }

        /// <inheritdoc />
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Dispose(true);
        }

        ~Camera()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                _device?.Dispose();
        }

        public void Init()
        {
            var inputDevices = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            for (var i = 0; i < inputDevices.Length; ++i)
            {
                if (!inputDevices[i].Name.Equals(_deviceName, StringComparison.InvariantCultureIgnoreCase))
                    continue;
                _device = inputDevices[i];
                DeviceIndex = i;
                break;
            }

            if (_device is null)
                ThrowHelper.ThrowDeviceNotFoundException(_deviceName);
        }

        public List<string> GetAllAvailableResolution()
        {
            try
            {
                int hr, bitCount = 0;

                IBaseFilter sourceFilter = null;

                var m_FilterGraph2 = new FilterGraph() as IFilterGraph2;
                hr = m_FilterGraph2.AddSourceFilterForMoniker(_device.Mon, null, _device.Name, out sourceFilter);
                var pRaw2 = DsFindPin.ByCategory(sourceFilter, PinCategory.Capture, 0);
                var AvailableResolutions = new List<string>();

                var v = new VideoInfoHeader();
                IEnumMediaTypes mediaTypeEnum;
                hr = pRaw2.EnumMediaTypes(out mediaTypeEnum);

                AMMediaType[] mediaTypes = new AMMediaType[1];
                IntPtr fetched = IntPtr.Zero;
                hr = mediaTypeEnum.Next(1, mediaTypes, fetched);

                while (fetched != null && mediaTypes[0] != null)
                {
                    Marshal.PtrToStructure(mediaTypes[0].formatPtr, v);
                    if (v.BmiHeader.Size != 0 && v.BmiHeader.BitCount != 0)
                    {
                        if (v.BmiHeader.BitCount > bitCount)
                        {
                            AvailableResolutions.Clear();
                            bitCount = v.BmiHeader.BitCount;
                        }
                        AvailableResolutions.Add(v.BmiHeader.Width + "x" + v.BmiHeader.Height);
                    }
                    hr = mediaTypeEnum.Next(1, mediaTypes, fetched);
                }
                return AvailableResolutions;
            }
            catch (Exception ex)
            {
                return new List<string>();
            }
        }
    }

    public class RecorderSettings
    {
        public string DeviceName { get; set; }
        public int FrameWidth { get; set; }
        public int FrameHeight { get; set; }
        public double Fps { get; set; }
    }

    public class Recorder : IDisposable
    {
        private readonly VideoCaptureAPIs _videoCaptureApi = VideoCaptureAPIs.DSHOW;
        private readonly ManualResetEventSlim _threadStopEvent = new(false);
        private readonly VideoCapture _videoCapture;
        private VideoWriter _videoWriter;

        private Mat _capturedFrame = new();
        private Thread _captureThread;
        private Thread _writerThread;

        private bool IsVideoCaptureValid => _videoCapture is not null && _videoCapture.IsOpened();

        public Recorder(int deviceIndex, int frameWidth, int frameHeight, double fps)
        {
            _videoCapture = VideoCapture.FromCamera(deviceIndex, _videoCaptureApi);
            _videoCapture.Open(deviceIndex, _videoCaptureApi);

            _videoCapture.FrameWidth = frameWidth;
            _videoCapture.FrameHeight = frameHeight;
            _videoCapture.Fps = fps;
        }

        /// <inheritdoc />
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Dispose(true);
        }

        ~Recorder()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                StopRecording();

                _videoCapture?.Release();
                _videoCapture?.Dispose();
            }
        }

        public void StartRecording(string path)
        {
            if (_writerThread is not null)
                return;

            if (!IsVideoCaptureValid)
                ThrowHelper.ThrowVideoCaptureNotReadyException();

            _videoWriter = new VideoWriter(path, FourCC.XVID, _videoCapture.Fps, new Size(_videoCapture.FrameWidth, _videoCapture.FrameHeight));

            _threadStopEvent.Reset();

            _captureThread = new Thread(CaptureFrameLoop);
            _captureThread.Start();

            _writerThread = new Thread(AddCameraFrameToRecordingThread);
            _writerThread.Start();
        }

        public void StopRecording()
        {
            _threadStopEvent.Set();

            _writerThread?.Join();
            _writerThread = null;

            _captureThread?.Join();
            _captureThread = null;

            _threadStopEvent.Reset();

            _videoWriter?.Release();
            _videoWriter?.Dispose();
            _videoWriter = null;
        }

        private void CaptureFrameLoop()
        {
            while (!_threadStopEvent.Wait(0))
            {
                _videoCapture.Read(_capturedFrame);
            }
        }

        private void AddCameraFrameToRecordingThread()
        {
            var waitTimeBetweenFrames = 1_000 / _videoCapture.Fps;
            var lastWrite = DateTime.Now;

            while (!_threadStopEvent.Wait(0))
            {
                if (DateTime.Now.Subtract(lastWrite).TotalMilliseconds < waitTimeBetweenFrames)
                    continue;
                lastWrite = DateTime.Now;
                _videoWriter.Write(_capturedFrame);
            }
        }

        public Bitmap GetFrameBitmap()
        {
            if (!IsVideoCaptureValid)
                ThrowHelper.ThrowVideoCaptureNotReadyException();

            using var frame = new Mat();
            return !_videoCapture.Read(frame) ? null : frame.ToBitmap();
        }
    }

    public class DeviceNotFoundException : Exception
    {
        public string DeviceName { get; }

        /// <inheritdoc />
        public DeviceNotFoundException()
        {
        }

        /// <inheritdoc />
        public DeviceNotFoundException(string message) : base(message)
        {
        }

        /// <inheritdoc />
        public DeviceNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public DeviceNotFoundException(string message, string deviceName) : base(message)
        {
            DeviceName = deviceName;
        }

        public DeviceNotFoundException(string message, Exception innerException, string deviceName) : base(message, innerException)
        {
            DeviceName = deviceName;
        }
    }

    public class VideoCaptureNotReadyException : Exception
    {
        /// <inheritdoc />
        public VideoCaptureNotReadyException()
        {
        }

        /// <inheritdoc />
        public VideoCaptureNotReadyException(string message) : base(message)
        {
        }

        /// <inheritdoc />
        public VideoCaptureNotReadyException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    internal static class ThrowHelper
    {
        public static void ThrowDeviceNotFoundException(string deviceName)
        {
            var sb = new StringBuilder($"Urządzenie o nazwie '{deviceName}' nie zostało odnalezione. Dostępne są następujące urządzenia: ");
            var inputDeviceNames = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice).Select(x => x.Name).ToArray();
            sb.Append(string.Join(", ", inputDeviceNames));
            throw new DeviceNotFoundException(sb.ToString(), null, deviceName);
        }

        public static void ThrowVideoCaptureNotReadyException()
        {
            throw new VideoCaptureNotReadyException();
        }
    }
}