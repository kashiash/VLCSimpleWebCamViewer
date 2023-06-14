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
            using var mediaPlayer = new MediaPlayer(libVLC);

            //  :dshow-vdev=Logitech StreamCam :dshow-adev=  :live-caching=100 - copied from VlcVideoPlayer

            media.AddOption(" :dshow-vdev=Logitech StreamCam :dshow-adev=  :live-caching=100"); 

            //   media.AddOption(" :dshow-vdev=\"Logitech StreamCam\" :dshow-adev=none  :live-caching=100");
            //   media.AddOption(" :dshow-vdev='Logitech StreamCam' :dshow-adev=none  :live-caching=100");

            //  media.AddOption(" :dshow-vdev=Integrated Camera :dshow-adev=none  :live-caching=100");


            media.AddOption(":sout=#duplicate{dst=display,dst=std{access=file,mux=ts,dst=xyz.avi}}");

            mediaPlayer.Play(media);



            System.Threading.Thread.Sleep(10000);
            mediaPlayer.Stop();

            // https://wiki.videolan.org/Documentation:Streaming_HowTo/Command_Line_Examples/

            // media.AddOption(" :dshow-vdev= :dshow-adev= :live-caching=30");
            //   media.AddOption($":sout=#file{{dst=record{DateTime.Now.Ticks}.mp4}}"); // save to file 

            //  // Display it on screen and svae to file



            //#duplicate{dst=display,dst="transcode{vcodec=mp4v,acodec=mpga,vb=800,ab = 128,deinterlace}:rtp{mux=ts,dst=239.255.12.42,sdp=sap,name="TestStream"}"}'


            //  media.AddOption(" :sout=#duplicate{dst=display\r\n,dst=#file{dst=record.mp4}}");
            //  media.AddOption(" :sout=\"#duplicate{dst=std{access=file,mux=asf,\r\ndst='C:\\test\\test.asf'},dst=nodisplay}\"");
            //  media.AddOption(":sout-keep");


            // https://stackoverflow.com/questions/10988089/rtsp-streaming-to-web-app-using-vlc-2-0?rq=1
            //cvlc rtsp://xxx.xxx.xxx.xxx:554/vga.sdp :sout='#transcode{vcodec=FLV1,vb=2048,fps=25,scale=1,acodec=none,deinterlace}:http{mime=video/x-flv,mux=ffmpeg{mux=flv},dst=127.0.0.1:8090/device_1.flv}' :no-sout-standard-sap :ttl=5 :sout-keep :no-audio --video --no-sout-audio 


            //  mediaPlayer.Fullscreen = true;

            //using var media2 = new Media(libVLC, "dshow://", FromType.FromLocation);
            //using var mediaPlayer2 = new MediaPlayer(media);


            //using var media3 = new Media(libVLC, "dshow://", FromType.FromLocation);
            //using var mediaPlayer3 = new MediaPlayer(media);

            // _mediaPlayer.Media = new Media(_libVLC, "dshow://  :dshow-vdev=Blackmagic WDM Capture
            // :dshow-adev=Entrée ligne (Blackmagic DeckLink Mini Recorder 4K Audio)
            // :dshow-aspect-ratio=16\\:9
            // :dshow-chroma=
            // :dshow-fps=50
            // :no-dshow-config
            // :no-dshow-tuner
            // :dshow-tuner-channel=0
            // :dshow-tuner-frequency=0
            // :dshow-tuner-country=0
            // :dshow-tuner-standard=0
            // :dshow-tuner-input=0
            // :dshow-video-input=-1
            // :dshow-video-output=-1
            // :dshow-audio-input=-1
            // :dshow-audio-output=-1
            // :dshow-amtuner-mode=1
            // :dshow-audio-channels=0
            // :dshow-audio-samplerate=0
            // :dshow-audio-bitspersample=0
            // :live-caching=300 ", FromType.FromPath);

            // _mediaPlayer.Media = new Media(_libVLC, "dshow:// ", FromType.FromLocation );
            // : _mediaPlayer.Media.AddOption(":dshow-vdev='Blackmagic WDM Capture'");
            // _mediaPlayer.Media.AddOption(":dshow-fps=50");

            //  mediaPlayer.SetLogoString(VideoLogoOption.Position , "VNC Rulez");


            //System.Threading.Thread.Sleep(10000);

            //using var media2 = new Media(libVLC, "dshow://", FromType.FromLocation);
            //using var mediaPlayer2 = new MediaPlayer(media2);
            //media2.AddOption($":sout=#file{{dst=record_XXX_{DateTime.Now.Ticks}.mp4}}");

            //mediaPlayer2.Play(media2);

            System.Threading.Thread.Sleep(10000);
           // mediaPlayer2.Stop();
           var res =  mediaPlayer.TakeSnapshot(0, "dupa1.png", 0, 0);
            System.Threading.Thread.Sleep(1000);
           res =  mediaPlayer.TakeSnapshot(0, "dupa2.png", 1920, 1080);
            System.Threading.Thread.Sleep(1000);
          res =   mediaPlayer.TakeSnapshot(0, "dupa3.png", 0, 0);
            System.Threading.Thread.Sleep(1000);


            mediaPlayer.TakeSnapshot(0, "dupa4.png", 0, 0);

            
            mediaPlayer.Stop();
        
        }
    }
}