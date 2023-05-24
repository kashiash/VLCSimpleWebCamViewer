using System;
using System.Reflection;
using LibVLCSharp.Shared;

namespace VlcConsoleBroadcastServer
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Core.Initialize();
            var file = new FileInfo(@"path");

            LibVLC libvlc = new LibVLC(enableDebugLogs: true);

            using (var mediaPlayer = new MediaPlayer(libvlc))
            {
                // Options without any encode
                var mediaOptions = new[]
                {
                    ":sout=#rtp{sdp=rtsp://10.0.4.91:8008/test}",
                    ":sout-keep"
                };
                var url = new Uri(@" https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4");
                var media = new Media(libvlc, url, mediaOptions);


                mediaPlayer.Play(media);

                Console.WriteLine("Streaming on rtsp://10.0.4.91:8008/test");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }

        }
    }
}