using System.Diagnostics;
using System;
using OpenCvSharp;

namespace ConsoleOpenCvRecorder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var capture = new VideoCapture();
            capture.Set(VideoCaptureProperties.FrameWidth, 640);
            capture.Set(VideoCaptureProperties.FrameHeight, 480);
            capture.Open(0);
            if (!capture.IsOpened())
                throw new Exception("capture initialization failed");

            var fs = FrameSource.CreateFrameSource_Camera(0);
            var sr = SuperResolution.CreateBTVL1();
            sr.SetInput(fs);

            using var normalWindow = new Window("normal");
            using var srWindow = new Window("super resolution");
            var normalFrame = new Mat();
            var srFrame = new Mat();
            while (true)
            {
                capture.Read(normalFrame);
                sr.NextFrame(srFrame);
                if (normalFrame.Empty() || srFrame.Empty())
                    break;
                normalWindow.ShowImage(normalFrame);
                srWindow.ShowImage(srFrame);
                Cv2.WaitKey(100);
            }
        }
    }
}