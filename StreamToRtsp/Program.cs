using LibVLCSharp.Shared;

namespace StreamToRtsp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string VIDEO_URL = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4";


            Core.Initialize();

            using var _libvlc = new LibVLC(enableDebugLogs: true);


            var player1 = new LibVLCSharp.Shared.MediaPlayer(_libvlc);
            var rtsp1 = new Media(_libvlc, VIDEO_URL, FromType.FromLocation);       //Create a media object and then set its options to duplicate streams - 1 on display 2 as RTSP
            rtsp1.AddOption(":sout=#duplicate" +
                "{dst=display{noaudio}," +
             //   "dst=rtp{mux=ts,dst=10.0.4.91,port=8554,sdp=rtsp://10.0.4.91:8554/go.sdp}}");  //The address has to be your local network adapters addres not localhost
            "dst=rtp{sdp=rtsp://10.0.4.91:8554/go.sdp}}");
            player1.EnableHardwareDecoding = true;
            player1.Play(rtsp1);

            System.Threading.Thread.Sleep(1000);

            var player2 = new LibVLCSharp.Shared.MediaPlayer(_libvlc);
            player2.Mute = true;
            player2.EnableHardwareDecoding = true;
            player2.Play(new Media(_libvlc, "rtsp://10.0.4.91:8554/go.sdp", FromType.FromLocation));


            //var player3 = new LibVLCSharp.Shared.MediaPlayer(_libvlc);
            //player3.Mute = true;
            //player3.Play(new Media(_libvlc, "rtsp://10.0.4.91:8554/go.sdp", FromType.FromLocation));


            Console.WriteLine("Streaming on rtsp://10.0.4.91:8554/go.sdp");
            Console.WriteLine("Press any key to exit");
           
            Console.ReadKey();
        }
    }
}