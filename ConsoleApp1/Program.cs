// See https://aka.ms/new-console-template for more information
using LibVLCSharp.Shared;

Console.WriteLine("Hello, World!");
using var libvlc = new LibVLC(enableDebugLogs: true);
using var media = new Media(libvlc, new Uri(@"rtsp://10.0.4.123:8554/webcam")); //new Uri(@"D:\gabos\big_buck_bunny.mp4"));
using var mediaplayer = new MediaPlayer(media);

//mediaplayer.Fullscreen = true;
mediaplayer.EnableHardwareDecoding = true;


mediaplayer.Play();


Console.ReadKey();
