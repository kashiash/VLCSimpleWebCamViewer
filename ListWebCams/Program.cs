using OpenCvSharp;

namespace ListWebCams
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 20; i++)
            {
                var cap0 = new VideoCapture(i,VideoCaptureAPIs.DSHOW);
                Console.WriteLine($"{} {cap0.CaptureType} {cap0.Fps} {cap0.FrameHeight} {cap0.FrameWidth}");
            }
          
        }
    }
}