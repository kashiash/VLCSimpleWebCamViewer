using System.Diagnostics;
using LibVLCSharp.Shared;
using System.Numerics;
using LibVLCSharp.WinForms;

namespace VlcClient
{
    public partial class Form1 : Form
    {

        LibVLC libvlc = new LibVLC(enableDebugLogs: true);
        public MediaPlayer player;
        public Media media;


        public bool isFullscreen = false;
        public bool isPlaying = false;
        public Size oldVideoSize;
        public Size oldFormSize;
        public Point oldVideoLocation;


        bool isDragging;
        int clickOffsetX;
        int clickOffsetY;


        public Form1()
        {
            Core.Initialize();
            InitializeComponent();

            oldVideoSize = vlcControl.Size;
            oldFormSize = this.Size;
            oldVideoLocation = vlcControl.Location;

            vlcControl.MouseMove += new MouseEventHandler(lblDragger_MouseMove);
            vlcControl.MouseUp += new MouseEventHandler(lblDragger_MouseUp);
            vlcControl.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            vlcControl.MouseDoubleClick += new MouseEventHandler(pictureBox1_MouseDown);

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ShortcutEvent);

            //    var url = new Uri("rtsp://10.0.4.91:8008/test");
            var url = new Uri(@"c:\movies\ElephantsDream.mp4");
            media = new Media(libvlc, url);
            media.DurationChanged += Media_DurationChanged;
            player = new MediaPlayer(libvlc);
            player.PositionChanged += Player_PositionChanged;
            vlcControl.MediaPlayer = player;

            vlcControl.MediaPlayer.Play(media);
            isPlaying = true;

            Debug.WriteLine(url);
        }

        private void Player_PositionChanged(object? sender, MediaPlayerPositionChangedEventArgs e)
        {
           // textBox4.Text = $"{player.Position * 100}";
           var pos = player.Position;
        }

        private void Media_DurationChanged(object? sender, MediaDurationChangedEventArgs e)
        {
            textBox3.Text = $"{media.Duration / 1000}";
        }

        private void pictureBox1_MouseDown(object? sender, MouseEventArgs e)
        {
            isDragging = true;
            clickOffsetX = e.X;
            clickOffsetY = e.Y;
        }

        private void lblDragger_MouseUp(object? sender, MouseEventArgs e)
        {
            // throw new NotImplementedException();
        }

        private void lblDragger_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging == true)
            {
                textBox1.Text = e.X.ToString();
                //  textBox2.Text = clickOffsetX.ToString();
            }
        }

        private void ShortcutEvent(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape && isFullscreen) // from fullscreen to window
            {
                DisableFullScreen();
            }

            if (e.KeyCode == Keys.F || e.KeyCode == Keys.F11)
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
                if (e.KeyCode == Keys.F11)
                {
                    player.ToggleFullscreen();
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
            player.Fullscreen = isFullscreen;
        }

        private void SetFullScreen()
        {
            //  menuStrip1.Visible = false; // goodbye menu strip
            vlcControl.Size = this.Size; // make video the same size as the form
            vlcControl.Location = new Point(0, 0); // remove the offset
            this.FormBorderStyle = FormBorderStyle.None; // change form style
            this.WindowState = FormWindowState.Maximized;

            isFullscreen = true;
            player.Fullscreen = isFullscreen;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            clickOffsetX = e.X;
            clickOffsetY = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging == true)
            {
                textBox1.Text = e.X.ToString();
                //  textBox2.Text = clickOffsetX.ToString();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void vlcControl_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void vlcControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging == true)
            {
                textBox1.Text = e.X.ToString();
                //  textBox2.Text = clickOffsetX.ToString();
            }
        }

        private void vlcControl_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            clickOffsetX = e.X;
            clickOffsetY = e.Y;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar1.Value.ToString();
            player.Position = trackBar1.Value / 100f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}