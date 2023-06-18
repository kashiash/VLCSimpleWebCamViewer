using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace WinFormOpenCVRec2
{
    public partial class Form1 : Form
    {

        private System.ComponentModel.BackgroundWorker backgroundWorkerDisplayer;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRecorder;
        private  VideoCapture capture;
        private VideoWriter videoWriter;
        private int currentCamera = 0;
        private bool camerachanging = false;
        public Form1()
        {
            InitializeComponent();
            InitBackgroundWorkers();

            capture = new VideoCapture();

        }

        private void InitBackgroundWorkers()
        {
            backgroundWorkerDisplayer = new System.ComponentModel.BackgroundWorker();
            backgroundWorkerRecorder = new System.ComponentModel.BackgroundWorker();

            backgroundWorkerDisplayer.WorkerSupportsCancellation = true;
            backgroundWorkerDisplayer.DoWork += BackgroundWorkerDisplayer_DoWork;
            backgroundWorkerDisplayer.WorkerReportsProgress = true;
            backgroundWorkerDisplayer.ProgressChanged += BackgroundWorkerDisplayer_ProgressChanged;

            backgroundWorkerRecorder.WorkerSupportsCancellation = true;
            backgroundWorkerRecorder.DoWork += BackgroundWorkerRecorder_DoWork;
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
                        if (frameMat != null && videoWriter != null)
                        {
                            videoWriter.Write(frameMat);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void BackgroundWorkerDisplayer_DoWork(object? sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (capture is null  || camerachanging) return; 

            var bgWorker = (BackgroundWorker)sender;

            while (!bgWorker.CancellationPending)
            {
                using (var frameMat = capture.RetrieveMat())
                {
                    try
                    {
                        if (frameMat != null)
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
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            capture.Open(1, VideoCaptureAPIs.ANY);
            if (!capture.IsOpened())
            {
                Close();
                return;
            }

            ClientSize = new System.Drawing.Size(capture.FrameWidth, capture.FrameHeight);

            backgroundWorkerDisplayer.RunWorkerAsync();

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
          //  StopRecording();
          //  Thread.Yield();
            StartRecording();

        }

        private void StartRecording()
        {
            var path = $"file{DateTime.Now.Ticks}.mp4";
            videoWriter = new VideoWriter(path, FourCC.HEVC, capture.Fps, new OpenCvSharp.Size(capture.FrameWidth, capture.FrameHeight));

            backgroundWorkerRecorder.RunWorkerAsync();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopRecording();
        }

        private void StopRecording()
        {
            backgroundWorkerRecorder.CancelAsync();
         
            videoWriter?.Release();
            videoWriter?.Dispose();
            videoWriter = null;
        }

        private void buttonChangeCamera_Click(object sender, EventArgs e)
        {

            backgroundWorkerDisplayer.CancelAsync();
            backgroundWorkerRecorder.CancelAsync();

            DisposeBackgroundWorkers();

            camerachanging = true;

            capture.Dispose();
            capture = null;
            capture = new VideoCapture();

            currentCamera = currentCamera == 0 ? 1 : 0;


            var res = capture.Open(currentCamera, VideoCaptureAPIs.ANY);
            if (!capture.IsOpened())
            {
                Close();
                return;
            }
            camerachanging = false;

            InitBackgroundWorkers();

        }


    }
}