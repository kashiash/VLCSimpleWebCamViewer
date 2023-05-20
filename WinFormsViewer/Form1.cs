using LibVLCSharp.Shared;

namespace WinFormsViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using var libvlc = new LibVLC(enableDebugLogs: true);
            using var media = new Media(libvlc, new Uri(@" https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4"));
            using var media2 = new Media(libvlc, new Uri(@" http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"));



            videoView1.MediaPlayer = new MediaPlayer(libvlc);
            videoView2.MediaPlayer = new MediaPlayer(libvlc);

            videoView1.MediaPlayer.Play(media);
            videoView2.MediaPlayer.Play(media2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void videoView1_Click(object sender, EventArgs e)
        {

        }

        private void videoView2_Click(object sender, EventArgs e)
        {

        }
    }
}