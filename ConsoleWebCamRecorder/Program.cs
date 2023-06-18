using System.ComponentModel;
using LibVLCSharp.Shared;
using System.ComponentModel;
using System;

namespace ConsoleWebCamRecorder
{
    internal class Program
    {


        static void Main(string[] args)
        {


            Core.Initialize();
            LibVLC libvlc = new LibVLC(enableDebugLogs: true);
            var player = new MediaPlayer(libvlc);
            var webCamMedia = new Media(libvlc, "dshow://", FromType.FromLocation);

            //webCamMedia.AddOption(":dshow-vdev=Logitech StreamCam"); 
         //   webCamMedia.AddOption(":dshow-vdev=AVerMedia ExtremeCap UVC");

         //   string destinationPath = RecordVideo(player, libvlc,0);


            // webCamMedia.AddOption(":dshow-adev=Logitech StreamCam");
            //   webCamMedia.AddOption(":live-caching=300");
            //  var string1 = $":sout=#duplicate{{dst=display,dst=\"transcode{{vcodec=h264}}:standard{{access=file,mux=mp4,dst=recording{DateTime.Now.Ticks}.mp4}}\"}}";
            //  var string2 = $":sout=#duplicate{{dst=display,dst=\"{TranscodeStringConverter.GetTranscodeString(TranscodePreset.None)}:standard{{access=file,mux=mp4,dst=recording{DateTime.Now.Ticks}.mp4}}\"}}";

            //  webCamMedia.AddOption($":sout=#duplicate{{dst=display,dst=\"transcode{{vcodec=h264}}:standard{{access=file,mux=mp4,dst=recording{DateTime.Now.Ticks}.mp4}}\"}}");
            //  webCamMedia.AddOption($":sout=#duplicate{{dst=display,dst=\"{mp4_vonly}:standard{{access=file,mux=mp4,dst=recording{DateTime.Now.Ticks}.mp4}}\"}}");
            //  player.EnableHardwareDecoding = true;



            RecordVideo(player, libvlc, 0.5m, 16);
            Thread.Sleep(10000);

            RecordVideo(player, libvlc, 0.25m, 16);
            Thread.Sleep(10000);

            RecordVideo(player, libvlc, 0.12m, 16);
            Thread.Sleep(10000);


            RecordVideo(player, libvlc, 1,16);
            Thread.Sleep(10000);
            RecordVideo(player, libvlc, 2, 16);
            Thread.Sleep(10000);
            RecordVideo(player, libvlc, 3, 16);
            Thread.Sleep(10000);
            RecordVideo(player, libvlc, 4, 16);
            Thread.Sleep(10000);

            RecordVideo(player, libvlc, 1, 32);
            Thread.Sleep(10000);
            RecordVideo(player, libvlc, 2, 32);
            Thread.Sleep(10000);
            RecordVideo(player, libvlc, 3, 32);
            Thread.Sleep(10000);
            RecordVideo(player, libvlc, 4, 32);
            Thread.Sleep(10000);
            return; 

            for (int i = 0; i < 100; i++)
            {
                player.Stop();
                webCamMedia.Dispose();
            var    destinationPath = RecordVideo(player, libvlc,i);

                webCamMedia = new Media(libvlc, "dshow://", FromType.FromLocation);

                //webCamMedia.AddOption(":dshow-vdev=Logitech StreamCam"); 

                
                player.Play(webCamMedia);
                Thread.Sleep(1000);
            }

            player.Stop();



        }

        private static string RecordVideo(MediaPlayer player, LibVLC libvlc, int i)
        {
            string Camera0 = "AVerMedia ExtremeCap UVC";
            string Camera1 = "Logitech StreamCam";

            using var webCamMedia = new Media(libvlc, "dshow://", FromType.FromLocation);
            if (i % 2 == 0)
            {
                webCamMedia.AddOption($":dshow-vdev={Camera0}");
            }
            else
            {
                webCamMedia.AddOption($":dshow-vdev={Camera1}");
            }

            var destinationPath = $"recording{DateTime.Now.Ticks}.mp4";
            webCamMedia.AddOption($":sout=#duplicate{{dst=display,dst=\"transcode{{vcodec=h264}}:standard{{access=file,mux=mp4,dst={destinationPath}}}\"}}");
            player.Play(webCamMedia);
            Thread.Sleep(10000);
            player.Stop();
            return destinationPath;
        }


        private static string RecordVideo(MediaPlayer player, LibVLC libvlc, decimal scale = 1, int cfr = 16, string codec = "h264")
        {
            string Camera0 = "AVerMedia ExtremeCap UVC";


            using var webCamMedia = new Media(libvlc, "dshow://", FromType.FromLocation);

                webCamMedia.AddOption($":dshow-vdev={Camera0}");



            var destinationPath = $"recording{DateTime.Now.Ticks}-{cfr}-{codec}.mp4";
            webCamMedia.AddOption($":sout=#duplicate{{dst=display,dst=\"transcode{{vcodec=h264,venc=x264{{cfr={cfr}}},scale={scale}}}:standard{{access=file,mux=mp4,dst={destinationPath}}}\"}}");
            player.Play(webCamMedia);
            Thread.Sleep(10000);
            player.Stop();
            return destinationPath;
        }

        public enum TranscodePreset
        {
            None = 0,
            // [DisplayName("MP4 high (h.264 + AAC)")]
            MP4High,

            // [DisplayName("MP4 low (h.264 + AAC)")]
            MP4Low,

            // [DisplayName("OGG high (Theora + Vorbis)")]
            OGGHigh,

            // [DisplayName("OGG low (Theora + Vorbis)")]
            OGGLow,

            // [DisplayName("WebM high (VP8 + Vorbis)")]
            WebMHigh,

            // [DisplayName("WebM low (VP8 + Vorbis)")]
            WebMLow
        }

        public static class TranscodeStringConverter
        {
            public static string GetTranscodeString(TranscodePreset preset)
            {
                switch (preset)
                {
                    case TranscodePreset.MP4High:
                        return "transcode{vcodec=h264,venc=x264{cfr=16},scale=1,acodec=mp4a,ab=160,channels=2,samplerate=44100}";
                    case TranscodePreset.MP4Low:
                        return "transcode{vcodec=h264,venc=x264{cfr=40},scale=1,acodec=mp4a,ab=96,channels=2,samplerate=44100}";
                    case TranscodePreset.OGGHigh:
                        return "transcode{vcodec=theo,venc=theora{quality=9},scale=1,acodec=vorb,ab=160,channels=2,samplerate=44100}";
                    case TranscodePreset.OGGLow:
                        return "transcode{vcodec=theo,venc=theora{quality=4},scale=1,acodec=vorb,ab=96,channels=2,samplerate=44100}";
                    case TranscodePreset.WebMHigh:
                        return "transcode{vcodec=VP80,vb=2000,scale=1,acodec=vorb,ab=160,channels=2,samplerate=44100}";
                    case TranscodePreset.WebMLow:
                        return "transcode{vcodec=VP80,vb=1000,scale=1,acodec=vorb,ab=96,channels=2,samplerate=44100}";
                    default:
                        return "transcode{vcodec=h264}";
                }
            }
        }

    }
}