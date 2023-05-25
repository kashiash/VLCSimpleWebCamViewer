using LibVLCSharp.Shared;
using System.Windows.Forms;

namespace WinFormsViewer
{
    public partial class Form1 : Form
    {
        LibVLC libvlc = new LibVLC(enableDebugLogs: true);


        public MediaPlayer player;
        public MediaPlayer webCamPlayer;
        public Media media;
        public Media webCamMedia;

        public bool isFullscreen = false;
        public bool isPlaying = false;
        public Size oldVideoSize;
        public Size oldFormSize;
        public Point oldVideoLocation;


        public Form1()
        {
            InitializeComponent();

            Core.Initialize();

            oldVideoSize = videoView1.Size;
            oldFormSize = this.Size;
            oldVideoLocation = videoView1.Location;

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ShortcutEvent);

            // using var media2 = new Media(libvlc, new Uri(@" http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"));

            player = new MediaPlayer(libvlc);

            videoView1.MediaPlayer = player;


            media = new Media(libvlc, new Uri(@" https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4"));

            player.Play(media);
            isPlaying = true;



            player.TimeChanged += Player_TimeChanged;
            player.PositionChanged += Player_PositionChanged;


        }

        private void Player_PositionChanged(object? sender, MediaPlayerPositionChangedEventArgs e)
        {

        }

        private void Player_TimeChanged(object? sender, MediaPlayerTimeChangedEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play(media);
            isPlaying = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
            isPlaying = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var res = player.TakeSnapshot(0, $"snapshot{DateTime.Now.Ticks}.png", 0, 0);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShortcutEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && isFullscreen) // from fullscreen to window
            {
                DisableFullScreen();
            }

            if (e.KeyCode == Keys.F11)
            {
                if (isFullscreen)
                {
                    DisableFullScreen();

                }
                else
                {
                    SetFullScreen();

                }
            }

            if (isPlaying) // while the video is playing
            {
                if (e.KeyCode == Keys.Space || e.KeyCode == Keys.K) // Pause and Play
                {
                    if (player.State == VLCState.Playing) // if is playing
                    {
                        player.Pause(); // pause
                    }
                    else // it's not playing?
                    {
                        player.Play(); // play
                        
                    }
                }

                if (e.KeyCode == Keys.J) // skip 1% backwards
                {
                    player.Position -= 0.01f;
                }
                if (e.KeyCode == Keys.L) // skip 1% forwards
                {
                    player.Position += 0.01f;
                }
                if (e.KeyCode == Keys.N) // skip 1% forwards
                {
                    player.NextFrame();

                }
                if (e.KeyCode == Keys.S)
                {
                    var res = player.TakeSnapshot(0, $"snapshot{DateTime.Now.Ticks}.png", 0, 0);
                }
                if (e.KeyCode == Keys.F11)
                {
                    player.ToggleFullscreen();

                }
            }
        }

        private void DisableFullScreen()
        {
            this.FormBorderStyle = FormBorderStyle.Sizable; // change form style
            this.WindowState = FormWindowState.Normal; // back to normal size
            this.Size = oldFormSize;
            //  menuStrip1.Visible = true; // the return of the menu strip 
            videoView1.Size = oldVideoSize; // make video the same size as the form
            videoView1.Location = oldVideoLocation; // remove the offset
            isFullscreen = false;
        }

        private void SetFullScreen()
        {
            //  menuStrip1.Visible = false; // goodbye menu strip
            videoView1.Size = this.Size; // make video the same size as the form
            videoView1.Location = new Point(0, 0); // remove the offset
            this.FormBorderStyle = FormBorderStyle.None; // change form style
            this.WindowState = FormWindowState.Maximized;

            isFullscreen = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.Position -= 0.01f;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player.Position += 0.01f;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            player.NextFrame();
        }



        private void button7_Click(object sender, EventArgs e)
        {

             webCamPlayer = new MediaPlayer(libvlc);
             webCamMedia = new Media(libvlc, "dshow://", FromType.FromLocation);

             videoView2.MediaPlayer = webCamPlayer;

            //  webCamMedia.AddOption(" :dshow-vdev= :dshow-adev=none :live-caching=0");

            //   media.AddOption(" :dshow-vdev=Logitech StreamCam :dshow-adev=Mikrofon (Logitech StreamCam)");
            webCamMedia.AddOption(" :dshow-vdev=Logitech StreamCam :dshow-adev=none  :live-caching=100");
            //  media.AddOption(" :dshow-vdev=Integrated Camera :dshow-adev=none  :live-caching=100");

            webCamMedia.AddOption(":sout=#duplicate{dst=display,dst=std{access=file,dst=xyz.mp4},dst=rtp{sdp=rtsp://10.0.4.91:8554/webcam}}");// "dst=rtp{sdp=rtsp://10.0.4.91:8554/go.sdp}}");
            webCamPlayer.EnableHardwareDecoding = true;
            webCamPlayer.Play(webCamMedia);




        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                player.Pause();
            }
            else
            {
                player.Play();
            }

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
            webCamPlayer.Stop();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (videoView2?.MediaPlayer?.IsPlaying == true)

            {
                videoView2?.MediaPlayer?.Pause();
                button9.Text = "Play";
            }
            else
            {
                videoView2?.MediaPlayer?.Play();
                button9.Text = "Pause";
            }


        }

        private void videoView3_Click(object sender, EventArgs e)
        {

        }


    }
}