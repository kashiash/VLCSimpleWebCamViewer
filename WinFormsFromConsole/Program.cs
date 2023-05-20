using LibVLCSharp.Shared;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace WinFormsFromConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Core.Initialize();

            using var libVLC = new LibVLC(enableDebugLogs: true);
            using var media = new Media(libVLC, "dshow://",FromType.FromLocation);
            //  media.AddOption(" :dshow-vdev=Logitech StreamCam :dshow-adev=Mikrofon (Logitech StreamCam)");
            //  media.AddOption(" :dshow-vdev=Logitech StreamCam :dshow-adev=none  :live-caching=100");
            //  media.AddOption(" :dshow-vdev=Integrated Camera :dshow-adev=none  :live-caching=100");

            media.AddOption(" :dshow-vdev= :dshow-adev= :live-caching=300");
            //media.AddOption($":sout=#file{{dst=record{DateTime.Now.Ticks}.mp4}}");
            //  // Display it on screen
            //  media.AddOption(":sout=#duplicate{dst=display,dst=std{access=file,mux=ps,dst=xyz.mp4}");
            //  media.AddOption(":sout-keep");


            media.AddOption(" :sout=#transcode{vcodec=h264,vb=0,scale=0,acodec=mp4a,ab=128,channels=2,samplerate=44100} :file{dst=record.mp4}");
            media.AddOption(" :sout-all :sout-keep");


            using var mediaPlayer = new MediaPlayer(media);
            mediaPlayer.Play();
            System.Threading.Thread.Sleep(15000);
            mediaPlayer.TakeSnapshot(0, "dupa1.png", 0, 0);
            System.Threading.Thread.Sleep(1000);
            mediaPlayer.TakeSnapshot(0, "dupa2.png", 0, 0);
            System.Threading.Thread.Sleep(1000);
            mediaPlayer.TakeSnapshot(0, "dupa3.png", 0, 0);
            System.Threading.Thread.Sleep(1000);
            mediaPlayer.TakeSnapshot(0, "dupa4.png", 0, 0);

            mediaPlayer.Stop();
        }
    }
}