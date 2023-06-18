using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinFormOpenCVRec2
{
    public partial class Form1 : Form
    {

        private System.ComponentModel.BackgroundWorker backgroundWorkerDisplayer;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRecorder;
        private VideoCapture capture;
        private VideoWriter videoWriter;
        private int currentCamera = 0;
        private bool camerachanging = false;
        private bool restartDisplayer = false;


        FourCC fourCC;
        VideoCaptureAPIs videoCaptureApi;
        int frameWidth;
        int frameHeight;
        public Form1()
        {
            InitializeComponent();
            InitBackgroundWorkers();

            cbRozdzielczoscVideo.SelectedIndex = 0;
            cbFormatVideo.SelectedIndex = 0;

        }

        private void InitBackgroundWorkers()
        {
            backgroundWorkerDisplayer = new System.ComponentModel.BackgroundWorker();
            backgroundWorkerRecorder = new System.ComponentModel.BackgroundWorker();

            backgroundWorkerDisplayer.WorkerSupportsCancellation = true;
            backgroundWorkerDisplayer.DoWork += BackgroundWorkerDisplayer_DoWork;
            backgroundWorkerDisplayer.WorkerReportsProgress = true;
            backgroundWorkerDisplayer.ProgressChanged += BackgroundWorkerDisplayer_ProgressChanged;
            backgroundWorkerDisplayer.RunWorkerCompleted += BackgroundWorkerDisplayer_RunWorkerCompleted;

            backgroundWorkerRecorder.WorkerSupportsCancellation = true;
            backgroundWorkerRecorder.DoWork += BackgroundWorkerRecorder_DoWork;
            backgroundWorkerRecorder.RunWorkerCompleted += BackgroundWorkerRecorder_RunWorkerCompleted;
        }

        private void BackgroundWorkerDisplayer_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            InvokeControlText(label2, "Zakonczono wyswietlanie");

            capture.Dispose();
            capture = null;

            if (restartDisplayer)
            {


                InitCamera();

                if (!capture.IsOpened())
                {
                    Close();
                    return;
                }
                restartDisplayer = false;
                backgroundWorkerDisplayer.RunWorkerAsync();
            }
        }

        private void BackgroundWorkerRecorder_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            videoWriter?.Dispose();
            videoWriter = null;
            InvokeControlText(label2, "Zakonczono nagrywanie");
        }

        private void DisposeBackgroundWorkers()
        {
            backgroundWorkerDisplayer.CancelAsync();
            backgroundWorkerRecorder.CancelAsync();

            backgroundWorkerDisplayer.DoWork -= BackgroundWorkerDisplayer_DoWork;
            backgroundWorkerDisplayer.ProgressChanged -= BackgroundWorkerDisplayer_ProgressChanged;
            backgroundWorkerRecorder.DoWork -= BackgroundWorkerRecorder_DoWork;


            backgroundWorkerDisplayer.Dispose();
            backgroundWorkerRecorder.Dispose();
            backgroundWorkerRecorder = null;
            backgroundWorkerDisplayer = null;
        }

        private void BackgroundWorkerDisplayer_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            var frameBitmap = (Bitmap)e.UserState;
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = frameBitmap;
        }

        private void BackgroundWorkerRecorder_DoWork(object? sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (capture is null || videoWriter is null || camerachanging) return;

            var bgWorker = (BackgroundWorker)sender;

            try
            {
                var waitTimeBetweenFrames = 1_000 / capture.Fps;
                var lastWrite = DateTime.Now;

                while (!bgWorker.CancellationPending)
                {
                    if (DateTime.Now.Subtract(lastWrite).TotalMilliseconds < waitTimeBetweenFrames)
                        continue;
                    lastWrite = DateTime.Now;
                    using (var frameMat = capture.RetrieveMat())
                    {
                        if (frameMat != null && videoWriter != null && !frameMat.Empty())
                        {
                            videoWriter.Write(frameMat);
                        }
                    }

                    InvokeControlText(label2, DateTime.Now.ToString());

                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        private void BackgroundWorkerDisplayer_DoWork(object? sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (capture is null || camerachanging) return;

            var bgWorker = (BackgroundWorker)sender;

            while (!bgWorker.CancellationPending)
            {
                using (var frameMat = capture.RetrieveMat())
                {
                    try
                    {
                        if (frameMat != null && !frameMat.Empty())
                        {
                            var frameBitmap = BitmapConverter.ToBitmap(frameMat);

                            bgWorker.ReportProgress(0, frameBitmap);

                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                Thread.Sleep(100);

                InvokeControlText(label1, DateTime.Now.ToString());
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            InitCamera();

            if (!capture.IsOpened())
            {
                Close();
                return;
            }

            ClientSize = new System.Drawing.Size(capture.FrameWidth, capture.FrameHeight);

            backgroundWorkerDisplayer.RunWorkerAsync();

        }

        private void InitCamera()
        {
            capture = new OpenCvSharp.VideoCapture(); //VideoCapture.FromCamera(deviceIndex, _videoCaptureApi);
            capture.Open(currentCamera, videoCaptureApi);

            capture.FrameWidth = frameWidth;
            capture.FrameHeight = frameHeight;
            capture.Fps = 29;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorkerDisplayer.CancelAsync();
            backgroundWorkerRecorder.CancelAsync();

            videoWriter?.Release();
            videoWriter?.Dispose();
            videoWriter = null;
            capture.Dispose();
            DisposeBackgroundWorkers();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartRecording();
        }

        private void StartRecording()
        {
            var path = $"file{DateTime.Now.Ticks}.mp4";


            capture = new VideoCapture();

            var res = capture.Open(1, VideoCaptureAPIs.ANY);
            if (!capture.IsOpened())
            {
                Close();
                return;
            }

            videoWriter = new VideoWriter(path, fourCC, capture.Fps, new OpenCvSharp.Size(frameWidth, frameHeight));

            backgroundWorkerRecorder.RunWorkerAsync();
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopRecording();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void StopRecording()
        {
            backgroundWorkerRecorder.CancelAsync();


            videoWriter?.Release();

        }

        private void buttonChangeCamera_Click(object sender, EventArgs e)
        {
            backgroundWorkerRecorder.CancelAsync();
            restartDisplayer = true;
            backgroundWorkerDisplayer.CancelAsync();


            currentCamera = currentCamera == 0 ? 1 : 0;
            label3.Text = $"current camera {currentCamera}";
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

        private void cbRozdzielczoscVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRozdzielczoscVideo.SelectedIndex == 0)
            {
                videoCaptureApi = VideoCaptureAPIs.DSHOW;
                frameWidth = 640;
                frameHeight = 480;
            }
            else if (cbRozdzielczoscVideo.SelectedIndex == 1)
            {
                videoCaptureApi = VideoCaptureAPIs.ANY;
                frameWidth = 1280;
                frameHeight = 720;
            }
            else if (cbRozdzielczoscVideo.SelectedIndex == 2)
            {
                videoCaptureApi = VideoCaptureAPIs.ANY;
                frameWidth = 1920;
                frameHeight = 1080;
            }

            backgroundWorkerRecorder.CancelAsync();
            restartDisplayer = true;
            backgroundWorkerDisplayer.CancelAsync();

        }

        private void cbFormatVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormatVideo.SelectedIndex == 0)
            {
                fourCC = FourCC.H265;
            }
            else if (cbFormatVideo.SelectedIndex == 1)
            {
                fourCC = FourCC.MPG4;
            }
            else if (cbFormatVideo.SelectedIndex == 2)
            {
                fourCC = FourCC.HEVC;
            }

            backgroundWorkerRecorder.CancelAsync();
            restartDisplayer = true;
            backgroundWorkerDisplayer.CancelAsync();
        }
    }


}