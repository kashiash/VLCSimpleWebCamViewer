using System.Numerics;
using LibVLCSharp.Shared;

namespace ManyPlayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Core.Initialize();

            using var _libVLC = new LibVLC(enableDebugLogs: true);


            using var _mp  = new MediaPlayer(_libVLC);
            using var _mp1 = new MediaPlayer(_libVLC);
            using var _mp2 = new MediaPlayer(_libVLC);

            //  :dshow-vdev=Logitech StreamCam :dshow-adev=  :live-caching=100 - copied from VlcVideoPlayer
            //var media = new Media(_libVLC, "dshow://", FromType.FromLocation);
            //media.AddOption(":dshow-vdev=Logitech StreamCam");
            //media.AddOption(":dshow-vdev=");

             var media = new Media(_libVLC, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"));
            media.AddOption(":sout=#std{access=http,mux=ts,dst=:8090/sample}");

            _mp.Play(media); // stream locally

            var media1 = new Media(_libVLC, new Uri("http://localhost:8090/sample"));
            _mp1.Play(media1); // playback

            var media2 = new Media(_libVLC, new Uri("http://localhost:8090/sample"));
            media2.AddOption($":sout=#duplicate{{dst=display,dst=\"transcode{{vcodec=h264}}:standard{{access=file,mux=mp4,dst=recording{DateTime.Now.Ticks}.mp4}}\"}}");
            _mp2.Play(media2); // record


            Task.Run(async () =>
            {
                await Task.Delay(2000);
                var result = _mp1.TakeSnapshot(0, $"snapshot{DateTime.Now.Ticks}.png", 0, 0);
            });
            Console.ReadKey();
        }
    }
}