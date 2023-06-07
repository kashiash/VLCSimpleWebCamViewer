using LibVLCSharp.Shared;

namespace ConsoleWebCamRecorder
{
    internal class Program
    {


        static void Main(string[] args)
        {
            LibVLC libvlc = new LibVLC(enableDebugLogs: true);
            Core.Initialize();
         
            var player = new MediaPlayer(libvlc);
          var  webCamMedia = new Media(libvlc, "dshow://", FromType.FromLocation);

            webCamMedia.AddOption(":dshow-vdev=Logitech StreamCam");
         //   webCamMedia.AddOption(":dshow-adev=Mikrofon (Logitech StreamCam)");
         //   webCamMedia.AddOption(":live-caching=300");

            webCamMedia.AddOption($":sout=#duplicate{{dst=display,dst=\"transcode{{vcodec=h264}}:standard{{access=file,mux=mp4,dst=recording{DateTime.Now.Ticks}.mp4}}\"}}");

            player.EnableHardwareDecoding = true;
            player.Play(webCamMedia);
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(5000);
                var res = player.TakeSnapshot(0, $"snapshot{DateTime.Now.Ticks}.png", 0, 0);
            }
          
            player.Stop(); // pause

        }
    }
}