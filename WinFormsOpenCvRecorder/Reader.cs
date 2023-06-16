using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static WinFormsOpenCvRecorder.Form1;

namespace WinFormsOpenCvRecorder
{
    public class Reader
    {
        private bool _run = false;
        private bool _endVideo = false;
        public int _speedVideo;
        private int _frameWidth;
        private int _frameHeight;
        private VideoCapture _capture;
        private Mat _image;
        private Thread _cameraThread;
        private string _videoFile = "";
        private PictureBox pictureBoxWebCam;
        private int _slider;
        private TrackBar _trackBar;
        //private maxSlider max;
        //private valSlider val;

        public Reader(string videoFile, PictureBox pictureBoxWebCam, int speedVideo, int frameWidth, int frameHeight, TrackBar trackBar)
        {
            _videoFile = videoFile;            
            this.pictureBoxWebCam = pictureBoxWebCam;
            this._speedVideo= speedVideo;
            this._frameWidth= frameWidth;
            this._frameHeight= frameHeight;
            _trackBar= trackBar;
            //this.max = max;
            //this.val = val; 
           // OnStart();
        }

        private void OnStart()
        {
            _image = new Mat();
            _cameraThread = new Thread(new ThreadStart(CaptureCameraCallback));
            _cameraThread.Start();
        }
        public void Start()
        {
            if (_capture == null || _endVideo)
            {
                _endVideo = false;
                _capture = new VideoCapture(_videoFile);
                OnStart();
            }
            _run = true;
        }

        public void Stop() 
        { 
            _run = false;
            _cameraThread = null;
            _capture.Dispose();
            _capture = null;
        }

        public void Pause()
        {
            _run = false;
        }

        private void CaptureCameraCallback()
        {
            try
            {
                SetMaxSlider(_capture.FrameCount);
                while (true)
                {
                    if (!_run) _capture.PosFrames--;
                    else SetValSlider(_capture.PosFrames);

                    _capture.Read(_image);
                    if (_image.Empty()) break;
                    var imageRes = new Mat();
                    Cv2.Resize(_image, imageRes, new OpenCvSharp.Size(_frameWidth, _frameHeight));
                    
                    var bmpWebCam = BitmapConverter.ToBitmap(imageRes);
                    pictureBoxWebCam.Image = bmpWebCam;
                    Thread.Sleep(_speedVideo);
                }
                _endVideo = true;
                Stop();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void SetMaxSlider(int x)
        {
            _trackBar.Invoke(new Action(delegate () { _trackBar.Maximum = x; }));
        }
        private void SetValSlider(int x)
        {
            _trackBar.Invoke(new Action(delegate () { _trackBar.Value = x; }));
        }
        public void SetCaptureFrame(int x)
        {
            _capture.PosFrames = x;
        }
    }
}
