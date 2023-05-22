using LibVLCSharp.Shared;
using System.Reflection;

namespace SaveHLS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var destination = Path.Combine(currentDirectory, "record.ts");

            // Load native libvlc library
            Core.Initialize();

            using (var libvlc = new LibVLC())
            using (var mediaPlayer = new MediaPlayer(libvlc))
            {

                mediaPlayer.Fullscreen = true;
                // Redirect log output to the console
                libvlc.Log += (sender, e) => Console.WriteLine($"[{e.Level}] {e.Module}:{e.Message}");

                // Create new media with HLS link
             //   var media = new Media(libvlc, "http://hls1.addictradio.net/addictrock_aac_hls/playlist.m3u8", FromType.FromLocation);
                using var media = new Media(libvlc, new Uri(@"https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4"));

                // Define stream output options. 
                // In this case stream to a file with the given path and play locally the stream while streaming it.
                media.AddOption(":sout=#file{dst=" + destination + "}");
                media.AddOption(":sout-keep");
                // libvlc_media_add_option(vlcMedia, ":sout=#duplicate{dst=display,dst=std{access=file,mux=ps,dst=xyz.mpg}");

                // Display it on screen
              //  media.AddOption( ":sout=#duplicate{dst=display,dst=std{access=file,mux=ps,dst=xyz.mpg}");

                // Start recording
                mediaPlayer.Play(media);

                Console.WriteLine($"Recording in {destination}");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}