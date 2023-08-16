
using System;
using OpenCvSharp;


using var capture = new VideoCapture(0, VideoCaptureAPIs.DSHOW);
if (!capture.IsOpened())
    return;

capture.FrameWidth = 1920;
capture.FrameHeight = 1280;
capture.AutoFocus = true;
capture.Fps = 10;

const int sleepTime = 10;

using var window = new Window("capture");
var image = new Mat();
const string OutVideoFile = "out.mp4";
//var dsize = new Size(capture.FrameWidth, capture.FrameHeight);
var dsize = new Size(640, 480);
using (var writer = new VideoWriter(OutVideoFile, FourCC.MPG4, capture.Fps, dsize))
{
    while (true)
    {
        capture.Read(image);
        if (image.Empty())
            break;


        //Console.CursorLeft = 0;
        //Console.Write("{0} / {1}", capture.PosFrames, capture.FrameCount);

        window.ShowImage(image);
        int c = Cv2.WaitKey(sleepTime);
        if (c >= 0)
        {
            break;
        }

        //using var dst = new Mat();

        //Cv2.Resize(image, dst, dsize, 0, 0, InterpolationFlags.Linear);
        //// Write mat to VideoWriter
        //writer.Write(dst);
        //writer.Write(image);
    }
    //Console.WriteLine();
}

