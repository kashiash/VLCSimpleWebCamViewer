using System.ComponentModel;
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
        private readonly VideoCapture capture;
        private VideoWriter videoWriter;
        public Form1()
        {
            InitializeComponent();
            backgroundWorkerDisplayer = new System.ComponentModel.BackgroundWorker();
            backgroundWorkerRecorder = new System.ComponentModel.BackgroundWorker();

            backgroundWorkerDisplayer.WorkerSupportsCancellation = true;
            backgroundWorkerDisplayer.DoWork += BackgroundWorkerDisplayer_DoWork;
            backgroundWorkerDisplayer.WorkerReportsProgress = true;
            backgroundWorkerDisplayer.ProgressChanged += BackgroundWorkerDisplayer_ProgressChanged;

            backgroundWorkerRecorder.WorkerSupportsCancellation = true;
            backgroundWorkerRecorder.DoWork += BackgroundWorkerRecorder_DoWork;
         

            capture = new VideoCapture();

        }

        private void BackgroundWorkerDisplayer_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            var frameBitmap = (Bitmap)e.UserState;
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = frameBitmap;
        }

        private void BackgroundWorkerRecorder_DoWork(object? sender, System.ComponentModel.DoWorkEventArgs e)
        {

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
                        if (videoWriter != null)
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
            var bgWorker = (BackgroundWorker)sender;

            while (!bgWorker.CancellationPending)
            {
                using (var frameMat = capture.RetrieveMat())
                {
                    try
                    {
                        var frameBitmap = BitmapConverter.ToBitmap(frameMat);
                        bgWorker.ReportProgress(0, frameBitmap);
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
            capture.Open(0, VideoCaptureAPIs.ANY);
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
            capture.Dispose();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StopRecording();
            Thread.Yield();
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
            //  capture.Dispose();
            videoWriter?.Release();
            videoWriter?.Dispose();
            videoWriter = null;
        }
    }
}