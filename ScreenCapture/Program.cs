using LibVLCSharp.Shared;
using System.Diagnostics;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ScreenRecorder
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Core.Initialize();



            using var libvlc = new LibVLC();

            Debug.WriteLine(libvlc.Version);
            Debug.WriteLine(libvlc.Changeset);
            Debug.WriteLine(libvlc.LibVLCCompiler);

            using var mediaPlayer = new MediaPlayer(libvlc);
            using var media = new Media(libvlc, "screen://", FromType.FromLocation);

            mediaPlayer.Playing += (s, e) => Debug.WriteLine(" Mediaplayer is playing");
            mediaPlayer.Paused += (s, e) => Debug.WriteLine(" Mediaplayer is paused");
            mediaPlayer.Stopped += (s, e) => Debug.WriteLine(" Mediaplayer is stopped");
            mediaPlayer.EndReached += (s, e) => Debug.WriteLine(" End of playback reached");
            mediaPlayer.EncounteredError += (s, e) => Debug.WriteLine("Playback encountered an error");


            media.AddOption(":screen-fps=24");
            media.AddOption($":sout=#transcode{{vcodec=h264,vb=0,scale=0,acodec=mp4a,ab=128,channels=2,samplerate=44100}}:file{{dst=record{DateTime.Now.Ticks}.mp4}}");
            media.AddOption(":sout-keep");

            mediaPlayer.Play(media); // start recording

            await Task.Delay(5000); // record for 5 seconds

            mediaPlayer.Stop(); // stop recording and saves the file
            Console.WriteLine("Finished. Press any key...");
            Console.ReadKey();
        }
    }
}
