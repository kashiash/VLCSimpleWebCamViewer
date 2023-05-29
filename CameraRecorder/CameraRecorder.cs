using System.Numerics;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

namespace CameraRecorder
{
    public partial class CameraRecorder : Form
    {
        LibVLC libvlc = new LibVLC(enableDebugLogs: true);

        public MediaPlayer player;

        public Media webCamMedia;

        public bool isFullscreen = false;
        public bool isRecording = false;
        public Size oldVideoSize;
        public Size oldFormSize;
        public Point oldVideoLocation;

        public CameraRecorder()
        {


            Core.Initialize();
            InitializeComponent();

            oldVideoSize = this.vlcControl.Size;
            oldFormSize = this.Size;
            oldVideoLocation = vlcControl.Location;

            this.KeyPreview = true;
            //    this.KeyDown += new KeyEventHandler(ShortcutEvent);


            player = new MediaPlayer(libvlc);
            webCamMedia = new Media(libvlc, "dshow://", FromType.FromLocation);

            vlcControl.MediaPlayer = player;

            webCamMedia.AddOption(" :dshow-vdev= :dshow-adev= :live-caching=0");

            //  media.AddOption(" :dshow-vdev=Logitech StreamCam :dshow-adev=Mikrofon (Logitech StreamCam)");
            //  webCamMedia.AddOption(" :dshow-vdev=Logitech StreamCam :dshow-adev=none  :live-caching=100");
            //  media.AddOption(" :dshow-vdev=Integrated Camera :dshow-adev=none  :live-caching=100");
            //  // Display it on screen and svae to file
            webCamMedia.AddOption($":sout=#duplicate{{dst=display,dst=std{{access=file,dst=recording{DateTime.Now.Ticks}.mp4}}}}");
            //   webCamMedia.AddOption(":sout=#duplicate{dst=display,dst=std{access=file,dst=xyz.mp4},dst=rtp{sdp=rtsp://10.0.4.91:8554/webcam}}");// "dst=rtp{sdp=rtsp://10.0.4.91:8554/go.sdp}}");
            player.EnableHardwareDecoding = true;
            player.Play(webCamMedia);
            isRecording = true;
            this.Text = "Recording";
            this.BackColor = Color.Red;
        }



        private void CameraRecorder_KeyDown(object sender, KeyEventArgs e)
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

            if (player.IsPlaying) // while the video is playing
            {
                if (e.KeyCode == Keys.Space || e.KeyCode == Keys.K) // Pause and Play
                {
                    if (isRecording == true) // if is playing
                    {
                        player.Stop(); // pause
                        webCamMedia = new Media(libvlc, "dshow://", FromType.FromLocation);
                        player.Play(webCamMedia); // play
                        this.Text = "playing";
                        this.BackColor = Color.Black;
                        isRecording = false;

                    }
                    else // it's not playing?
                    {
                        webCamMedia = new Media(libvlc, "dshow://", FromType.FromLocation);
                        webCamMedia.AddOption($":sout=#duplicate{{dst=display,dst=std{{access=file,dst=recording{DateTime.Now.Ticks}.mp4}}}}");
                        player.Play(webCamMedia); // play
                        this.Text = "recording";
                        this.BackColor = Color.Red;
                        isRecording = true;
                    }
                }

                //if (e.KeyCode == Keys.J) // skip 1% backwards
                //{
                //    player.Position -= 0.01f;
                //}
                //if (e.KeyCode == Keys.L) // skip 1% forwards
                //{
                //    player.Position += 0.01f;
                //}
                //if (e.KeyCode == Keys.N) // skip 1% forwards
                //{
                //    player.NextFrame();

                //}
                //if (e.KeyCode == Keys.S)
                //{
                //    var res = player.TakeSnapshot(0, $"snapshot{DateTime.Now.Ticks}.png", 0, 0);
                //}
                //if (e.KeyCode == Keys.F11)
                //{
                //    player.ToggleFullscreen();

                //}
            }
        }



        private void DisableFullScreen()
        {
            this.FormBorderStyle = FormBorderStyle.Sizable; // change form style
            this.WindowState = FormWindowState.Normal; // back to normal size
            this.Size = oldFormSize;
            //  menuStrip1.Visible = true; // the return of the menu strip 
            vlcControl.Size = oldVideoSize; // make video the same size as the form
            vlcControl.Location = oldVideoLocation; // remove the offset
            isFullscreen = false;
        }

        private void SetFullScreen()
        {
            //  menuStrip1.Visible = false; // goodbye menu strip
            vlcControl.Size = this.Size; // make video the same size as the form
            vlcControl.Location = new Point(0, 0); // remove the offset
            this.FormBorderStyle = FormBorderStyle.None; // change form style
            this.WindowState = FormWindowState.Maximized;

            isFullscreen = true;
        }


    }
}