using System.Diagnostics;

namespace WinFormsOpenCvRecorder
{
    public partial class Form1 : Form
    {

        Recorder recorder = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            try
            {
                recorder = new Recorder(1, 1920, 1080, 15, pictureBox1);

              

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
                recorder = new Recorder(1, 1920, 1080, 15, pictureBox1);
            }

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
    }


}