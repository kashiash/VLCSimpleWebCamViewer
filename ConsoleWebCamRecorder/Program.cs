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
            webCamMedia.AddOption(":dshow-vdev=AVerMedia ExtremeCap UVC");

            string destinationPath = RecordVideo(player, libvlc);


            // webCamMedia.AddOption(":dshow-adev=Logitech StreamCam");
            //   webCamMedia.AddOption(":live-caching=300");
            //  var string1 = $":sout=#duplicate{{dst=display,dst=\"transcode{{vcodec=h264}}:standard{{access=file,mux=mp4,dst=recording{DateTime.Now.Ticks}.mp4}}\"}}";
            //  var string2 = $":sout=#duplicate{{dst=display,dst=\"{TranscodeStringConverter.GetTranscodeString(TranscodePreset.None)}:standard{{access=file,mux=mp4,dst=recording{DateTime.Now.Ticks}.mp4}}\"}}";

            //  webCamMedia.AddOption($":sout=#duplicate{{dst=display,dst=\"transcode{{vcodec=h264}}:standard{{access=file,mux=mp4,dst=recording{DateTime.Now.Ticks}.mp4}}\"}}");
            //  webCamMedia.AddOption($":sout=#duplicate{{dst=display,dst=\"{mp4_vonly}:standard{{access=file,mux=mp4,dst=recording{DateTime.Now.Ticks}.mp4}}\"}}");
            //  player.EnableHardwareDecoding = true;


            for (int i = 0; i < 100; i++)
            {
                player.Stop();
                webCamMedia.Dispose();
                destinationPath = RecordVideo(player, libvlc);

                webCamMedia = new Media(libvlc, "dshow://", FromType.FromLocation);

                //webCamMedia.AddOption(":dshow-vdev=Logitech StreamCam"); 
                webCamMedia.AddOption(":dshow-vdev=AVerMedia ExtremeCap UVC");
                player.Play(webCamMedia);
                Thread.Sleep(1000);
            }

            player.Stop();



        }

        private static string RecordVideo(MediaPlayer player, LibVLC libvlc)
        {
            using var webCamMedia = new Media(libvlc, "dshow://", FromType.FromLocation);
            var destinationPath = $"recording{DateTime.Now.Ticks}.mp4";
            webCamMedia.AddOption($":sout=#duplicate{{dst=display,dst=\"transcode{{vcodec=h264}}:standard{{access=file,mux=mp4,dst={destinationPath}}}\"}}");
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