using OpenCvSharp;
using System.Diagnostics;

namespace WinFormsOpenCvRecorder
{
    public partial class Form1 : Form
    {

        Recorder recorder = null;
        int frameWidth;
        int frameHeight;
        FourCC fourCC;
        public Form1()
        {
            InitializeComponent();
            cbRozdzielczoscVideo.SelectedIndex = 0;
            cbFormatVideo.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                recorder = new Recorder(0, frameWidth, frameHeight, 15, pictureBox1, fourCC);
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
            recorder.Dispose();
            recorder = null;
            button1.Text = "START";
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Enabled = true;
            recorder = new Recorder(0, frameWidth, frameHeight, 15, pictureBox1, fourCC);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recorder.Dispose();
            recorder = null;
            button1.Text = "REC";
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            recorder = new Recorder(0, frameWidth, frameHeight, 15, pictureBox1, fourCC);
            Debug.WriteLine($"before start {Utils.SizeOf(recorder)}");
            recorder.StartRecording($"file{DateTime.Now.Ticks}.mp4");
            
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

        private void cbRozdzielczoscVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRozdzielczoscVideo.SelectedIndex == 0)
            {
                frameWidth = 640;
                frameHeight= 480;
            }
            else if (cbRozdzielczoscVideo.SelectedIndex == 1)
            {
                frameWidth = 1280;
                frameHeight = 720;
            }
            else if (cbRozdzielczoscVideo.SelectedIndex == 2)
            {
                frameWidth = 1920;
                frameHeight = 1080;
            }
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
        }
    }


}