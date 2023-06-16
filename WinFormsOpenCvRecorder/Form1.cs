using OpenCvSharp;
using System.Diagnostics;

namespace WinFormsOpenCvRecorder
{
    public partial class Form1 : Form
    {
        private string nameFile = "";
        private int speedVideo;
        Recorder recorder = null;
        Reader reader = null;
        public Form1()
        {
            InitializeComponent();
            cbxSpeed.SelectedIndex = 3;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                recorder = new Recorder(1, 640, 380, 15, pictureBox1);

              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Debug.WriteLine($"before stop {Utils.SizeOf(recorder)}");
            recorder.StopRecording();
            Debug.WriteLine($"after stop {Utils.SizeOf(recorder)}");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (recorder is null)
            {
                recorder = new Recorder(1, 640, 380, 15, pictureBox1);
            }

            Debug.WriteLine($"before start {Utils.SizeOf(recorder)}");
            nameFile = $"file{DateTime.Now.Ticks}.mp4";
            recorder.StartRecording(nameFile);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            recorder.TakeSnapshot();
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            Debug.WriteLine($"before stop {Utils.SizeOf(recorder)}");
            recorder.StopRecording();
            Debug.WriteLine($"after stop {Utils.SizeOf(recorder)}");

            recorder.Dispose();
            Debug.WriteLine($"after dispose {Utils.SizeOf(recorder)}");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (reader == null)
            {
                reader = new Reader(nameFile, picReader, speedVideo, 640, 380, trackBar1);
            }
            reader.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (reader != null) reader.Pause();
        }

        private void cbxSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (cbxSpeed.SelectedIndex == 0) reader._speedVideo = 200;
                else if (cbxSpeed.SelectedIndex == 1) reader._speedVideo = 120;
                else if (cbxSpeed.SelectedIndex == 2) reader._speedVideo = 70;
                else if (cbxSpeed.SelectedIndex == 3) reader._speedVideo = 30;
                else if (cbxSpeed.SelectedIndex == 4) reader._speedVideo = 20;
                else if (cbxSpeed.SelectedIndex == 5) reader._speedVideo = 10;
                else if (cbxSpeed.SelectedIndex == 6) reader._speedVideo = 0;
            }
            else
            {
                if (cbxSpeed.SelectedIndex == 0) speedVideo = 200;
                else if (cbxSpeed.SelectedIndex == 1) speedVideo = 120;
                else if (cbxSpeed.SelectedIndex == 2) speedVideo = 70;
                else if (cbxSpeed.SelectedIndex == 3) speedVideo = 30;
                else if (cbxSpeed.SelectedIndex == 4) speedVideo = 20;
                else if (cbxSpeed.SelectedIndex == 5) speedVideo = 10;
                else if (cbxSpeed.SelectedIndex == 6) speedVideo = 0;
            }
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (reader != null) reader.SetCaptureFrame(trackBar1.Value);
        }
    }


}