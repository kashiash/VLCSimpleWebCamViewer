using OpenCvSharp;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace WinFormsOpenCvRecorder
{
    public partial class Form1 : Form
    {

        Recorder recorder = null;
        int frameWidth;
        int frameHeight;
        FourCC fourCC;
        VideoCaptureAPIs videoCaptureApi;
        int fps = 15;
        int selectedCamera;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                GetAllConnectedCameras();
                cbCamera.SelectedIndex = 0;
                cbRozdzielczoscVideo.SelectedIndex = 0;
                cbFormatVideo.SelectedIndex = 0;
                recorder = new Recorder(selectedCamera, frameWidth, frameHeight, fps, pictureBox1, fourCC, videoCaptureApi);
                LoadMultimedia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadMultimedia()
        {
            flowLayoutPanel1.Controls.Clear();
            var file = Directory.GetFiles("C:\\Users\\rmajewski\\source\\repos\\kashiash\\VLCSimpleWebCamViewer\\WinFormsOpenCvRecorder\\bin\\Debug\\net7.0-windows\\multimedia", "");
            var list = new List<MultimediaControl>();
            foreach (var item in file)
            {
                if (item.Contains(".mp4"))
                {
                    var img = GetFrameFromVideo(item);
                    list.Add(new MultimediaControl(Properties.Resources.MovieIco, img));
                }
                else
                {
                    var img = new Bitmap(item);
                    list.Add(new MultimediaControl(Properties.Resources.screenshot_32, img));
                }

            }
            flowLayoutPanel1.Controls.AddRange(list.ToArray());
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {

            Debug.WriteLine($"before stop {Utils.SizeOf(recorder)}");
            recorder.StopRecording();
            Debug.WriteLine($"after stop {Utils.SizeOf(recorder)}");
            recorder.Dispose();
            recorder = null;
            buttonStart.Text = "START";
            buttonStart.BackColor = SystemColors.ControlLightLight;
            buttonStart.Enabled = true;
            recorder = new Recorder(selectedCamera, frameWidth, frameHeight, fps, pictureBox1, fourCC, videoCaptureApi);

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            recorder.Dispose();
            recorder = null;
            buttonStart.Text = "REC";
            buttonStart.BackColor = Color.Red;
            buttonStart.Enabled = false;
            recorder = new Recorder(selectedCamera, frameWidth, frameHeight, fps, pictureBox1, fourCC, videoCaptureApi);

            Debug.WriteLine($"before start {Utils.SizeOf(recorder)}");
            recorder.StartRecording($"multimedia\\file{DateTime.Now.Ticks}.mp4");

        }

        private void buttonTakeSnapshot_Click(object sender, EventArgs e)
        {
            recorder.TakeSnapshot();
            LoadMultimedia();
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
        private void cbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCamera = cbCamera.SelectedIndex;
            //if (recorder != null)
            //{
            //    Debug.WriteLine($"before stop {Utils.SizeOf(recorder)}");
            //    recorder.StopRecording();
            //    Debug.WriteLine($"after stop {Utils.SizeOf(recorder)}");
            //    recorder.Dispose();
            //    recorder = null;
            //}
            //recorder = new Recorder(selectedCamera, frameWidth, frameHeight, fps, pictureBox1, fourCC, videoCaptureApi);
            //recorder.StartRecording($"file{DateTime.Now.Ticks}.mp4");
        }

        public void GetAllConnectedCameras()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE (PNPClass = 'Image' OR PNPClass = 'Camera')"))
            {
                foreach (var device in searcher.Get())
                {
                    cbCamera.Items.Add(device["Caption"].ToString());
                }
            }

        }

        private Bitmap GetFrameFromVideo(string path)
        {
            VideoCapture _video = new VideoCapture(path);

            var ms = new MemoryStream();
            Mat mat = new Mat();
            _video.Read(mat);
            mat.Clone().ToMemoryStream(".png").CopyTo(ms);

            return new Bitmap(ms);
        }


    }


}