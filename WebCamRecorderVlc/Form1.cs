using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

namespace WebCamRecorderVlc
{
    public partial class Form1 : Form
    {

        private LibVLC libVLC;
        private MediaPlayer mediaPlayer;
        private Media media;
        private string videoFilePath = "recorded_video.mp4";


        public Form1()
        {
            InitializeComponent();



        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Core.Initialize();

            // Create LibVLC instance
            libVLC = new LibVLC();

            // Create MediaPlayer instance
            mediaPlayer = new MediaPlayer(libVLC);

            // Create Media instance for webcam capture
            media = new Media(libVLC, "dshow://", FromType.FromLocation);

            // Set video output format
            media.AddOption(":sout=#transcode{vcodec=h264}:file{dst=" + videoFilePath + "}");

            // Create VideoView control
            var videoView = new VideoView
            {
                Dock = DockStyle.Fill,
                MediaPlayer = mediaPlayer
            };

            // Add VideoView control to the form
            Controls.Add(videoView);

            // Set media to MediaPlayer
            mediaPlayer.Play(media);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Release resources when closing the form
            mediaPlayer.Stop();
            media.Dispose();
            mediaPlayer.Dispose();
            libVLC.Dispose();
        }
    }
}