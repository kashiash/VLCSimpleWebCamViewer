using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibVLCSharp.Shared;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace VlcClient
{
    public partial class PlayerControl : UserControl
    {

        LibVLC libvlc = new LibVLC(enableDebugLogs: true);
        public MediaPlayer player;
        public Media media;
        public string filePath;



        bool isDragging;
        public PlayerControl(string filePath)
        {
            this.filePath = filePath;
            Core.Initialize();
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(ShortcutEvent);
        }


        private void PlayerControl_Load(object sender, EventArgs e)
        {
            if (!Path.Exists(filePath))
            {
                filePath = @"c:\movies\gabos-box-1.mp4";
            }
            var url = new Uri(filePath);
            media = new Media(libvlc, url);

            player = new MediaPlayer(libvlc);
            player.PositionChanged += Player_PositionChanged;
            player.TimeChanged += Player_TimeChanged;
            player.LengthChanged += Player_LengthChanged;
            player.EndReached += Player_EndReached;
            vlcControl.MediaPlayer = player;

            vlcControl.MediaPlayer.Play(media);

            Play();

        }

        private void PlayerControl_Leave(object sender, EventArgs e)
        {

            media.Dispose();
            player.Dispose();
            libvlc.Dispose();

        }

        private void Player_EndReached(object? sender, EventArgs e)
        {
            Stop();
        }

        private void Player_LengthChanged(object? sender, MediaPlayerLengthChangedEventArgs e)
        {
            string time = TimeSpan.FromMilliseconds(e.Length).ToString(@"hh\:mm\:ss");
            NotifyDuration(time, e.Length);
        }





        private void Player_TimeChanged(object? sender, MediaPlayerTimeChangedEventArgs e)
        {
            string time = TimeSpan.FromMilliseconds(e.Time).ToString(@"hh\:mm\:ss");
            NotifyTime(time, e.Time, 0);
        }

        private void Player_PositionChanged(object? sender, MediaPlayerPositionChangedEventArgs e)
        {

            Console.WriteLine(e.Position * 1000);

        }


        public void NotifyTime(string time, long time_t, int instance = 0)
        {

            InvokeControlText(lblTime, time);
            if (m_trackDown == true)
                return;
            InvokeTrackerValue(trackBar1, (int)(time_t / 1000));
        }

        public void NotifyDuration(string time, long mvt, int instance = 0)
        {
            InvokeControlText(lblMovieDuration, time);
            mvt = mvt / 1000;
            InvokeTrackerMaximum(trackBar1, (int)mvt);
        }


        public static void InvokeControlButton(Control control, bool visibility)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Visible = visibility;
                });
            }
            else
            {
                control.Visible = visibility;
            }
        }
        public static void InvokeControlText<T>(Control control, T e)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Text = e.ToString();
                });
            }
            else
            {
                control.Text = e.ToString();
            }
        }

        public static void InvokeTrackerValue(TrackBar control, int value)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Value = value;
                });
            }
            else
            {
                control.Value = value;
            }
        }

        public static void InvokeTrackerMaximum(TrackBar control, int value)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke((MethodInvoker)delegate ()
                {
                    control.Maximum = value;
                });
            }
            else
            {
                control.Maximum = value;
            }
        }

        bool m_trackDown = false;
        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            m_trackDown = true;
            player.Time = trackBar1.Value * 1000;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            m_trackDown = false;
        }

        private void trackBar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_trackDown == true)
            {
                player.Time = trackBar1.Value * 1000;
            }
        }




        public void ShortcutEvent(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.K) // Pause and Play
            {
                if (player.State == VLCState.Playing) // if is playing
                {
                    Pause();
                }
                else // it's not playing?
                {
                    Play();

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
                var res = player.TakeSnapshot(0, getSnapshotPath(), 0, 0);
            }

        }

        private string getSnapshotPath()
        {
            return $"snapshot{DateTime.Now.Ticks}_{lblTime.Text.Replace(":", ".")}.png";
        }


        private void playButton_Click(object sender, EventArgs e)
        {
            if (player.State == VLCState.Playing) // if is playing
            {

                Pause();
            }
            else // it's not playing?
            {

                Play();

            }
        }

        public void Pause()
        {

            //pauseButton.Visible = false;
            //playButton.Visible = true;
            InvokeControlButton(pauseButton, false);
            InvokeControlButton(playButton, true);
            InvokeControlButton(trackBar1, true);
            ThreadPool.QueueUserWorkItem(_ => player.Pause());
        }

        public void Stop()
        {

            InvokeControlButton(pauseButton, false);
            InvokeControlButton(playButton, true);
            InvokeControlButton(trackBar1, false);
            ThreadPool.QueueUserWorkItem(_ => player.Stop());

            // pauseButton.Visible = false;
            // playButton.Visible = true;
            //// player.Stop(); // pause
            // ThreadPool.QueueUserWorkItem(_ => player.Stop());
        }

        public void Play()
        {
            InvokeControlButton(pauseButton, true);
            InvokeControlButton(playButton, false);
            ThreadPool.QueueUserWorkItem(_ => player.Play());
            InvokeControlButton(trackBar1, true);
            //  player.Play();
            //pauseButton.Visible = true;
            //playButton.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            player.Position -= 0.01f;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            player.Position += 0.01f;
        }

        private void snapshotButton_Click(object sender, EventArgs e)
        {
            var path = getSnapshotPath();
            var res = player.TakeSnapshot(0, path, 0, 0);
        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            player.NextFrame();
        }
    }
}
