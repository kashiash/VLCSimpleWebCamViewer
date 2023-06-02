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
                recorder = new Recorder(0, 1920, 1080, 15, pictureBox1);

              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            recorder.StopRecording();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            recorder.StartRecording($"file{DateTime.Now.Ticks}.mp4");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            recorder.TakeSnapshot();
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            recorder.StopRecording();
            recorder.Dispose();
        }
    }


}