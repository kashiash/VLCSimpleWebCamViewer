using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibVLCSharp.Shared;

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
            vlcControl.MediaPlayer = player;

            vlcControl.MediaPlayer.Play(media);

            Play();

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




        private void ShortcutEvent(object sender, KeyEventArgs e)
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
                    var res = player.TakeSnapshot(0, $"snapshot{DateTime.Now.Ticks}.png", 0, 0);
                }
            
        }

        private void vlcControl_Click(object sender, EventArgs e)
        {

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
            player.Pause(); // pause
            pauseButton.Visible = false;
            playButton.Visible = true;
        }

        public void Stop()
        {
            player.Stop(); // pause
            pauseButton.Visible = false;
            playButton.Visible = true;
        }

        public void Play()
        {
            player.Play();
            pauseButton.Visible = true;
            playButton.Visible = false;
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
            var res = player.TakeSnapshot(0, $"snapshot{DateTime.Now.Ticks}.png", 0, 0);
        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            player.NextFrame();
        }
    }
}
