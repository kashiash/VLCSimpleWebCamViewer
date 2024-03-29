using Newtonsoft.Json;
using OpenCvSharp;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VideoInputDevices;

namespace WinFormsOpenCvRecorder
{
    public partial class FormGrabber : Form
    {

        Recorder recorder = null;
        int frameWidth = 1280;
        int frameHeight = 720;
        FourCC fourCC = FourCC.HEVC;
        VideoCaptureAPIs videoCaptureApi = VideoCaptureAPIs.DSHOW;
        int fps = 15;
        int selectedCamera;
        string link = "";
        string fileRecord = "";
        public FormGrabber()
        {
            InitializeComponent();
            link = $"multimedia\\{Guid.NewGuid().ToString()}";
            Directory.CreateDirectory(link);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                GetAllConnectedCameras();
                cbCamera.SelectedIndex = 0;
                LoadSettings();

                LoadMultimedia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RunRecorder()
        {
            if (recorder != null)
            {
                Debug.WriteLine($"before stop {Utils.SizeOf(recorder)}");
                recorder.StopRecording();
                Debug.WriteLine($"after stop {Utils.SizeOf(recorder)}");

                recorder.Dispose();
                Debug.WriteLine($"after dispose {Utils.SizeOf(recorder)}");
                recorder = null;
            }
            recorder = new Recorder(selectedCamera, frameWidth, frameHeight, fps, pbRecorder, fourCC, videoCaptureApi);
        }
        private List<CameraSettings> GetCameraSettings()
        {
            var list = new List<CameraSettings>();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ApplicationSettings))
            {
                list = JsonConvert.DeserializeObject<List<CameraSettings>>(Properties.Settings.Default.ApplicationSettings);
            }
            return list;
        }
        private int GetWidthResolution(string resolution)
        {
            var res = resolution.Split('x');
            return int.Parse(res[0]);
        }
        private int GetHeightResolution(string resolution)
        {
            var res = resolution.Split('x');
            return int.Parse(Regex.Replace(res[1], "[^0-9.]", ""));
        }
        private void LoadSettings()
        {
            var settings = GetCameraSettings();
            var sett = settings.FirstOrDefault(x => x.CameraName == cbCamera.Text);
            if (sett != null)
            {
                frameWidth = GetWidthResolution(sett.RozdzielczoscVideo);
                frameHeight = GetHeightResolution(sett.RozdzielczoscVideo);
                fourCC = (int)sett.FormatVideo;
                fps = sett.FPS;
                //videoCaptureApi = settings.VideoCaptureApi;
                //fps = settings.Fps;
                //selectedCamera = settings.SelectedCamera;
            }
            //RunRecorder();
        }
        private void LoadMultimedia()
        {
            flowLayoutPanel1.Controls.Clear();
            var file = Directory.GetFiles(link, "");
            var list = new List<MultimediaControl>();
            foreach (var item in file)
            {
                if (string.IsNullOrEmpty(fileRecord) || !item.Contains(fileRecord))
                {
                    if (item.Contains(".mp4"))
                    {
                        var img = GetFrameFromVideo(item);
                        var video = new MultimediaControl(Properties.Resources.MovieIco, img, item, this);
                        video.IsVideo = true;
                        list.Add(video);
                    }
                    else
                    {
                        var img = new Bitmap(item);
                        list.Add(new MultimediaControl(Properties.Resources.screenshot_32, img, item, this));
                    }
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
            recorder = new Recorder(selectedCamera, frameWidth, frameHeight, fps, pbRecorder, fourCC, videoCaptureApi);
            fileRecord = "";
            LoadMultimedia();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabRecorder;
            recorder.Dispose();
            recorder = null;
            buttonStart.Text = "REC";
            buttonStart.BackColor = Color.Red;
            buttonStart.Enabled = false;
            recorder = new Recorder(selectedCamera, frameWidth, frameHeight, fps, pbRecorder, fourCC, videoCaptureApi);

            Debug.WriteLine($"before start {Utils.SizeOf(recorder)}");
            fileRecord = $"file{DateTime.Now.Ticks}.mp4";
            recorder.StartRecording($"{link}\\{fileRecord}");

        }

        private void buttonTakeSnapshot_Click(object sender, EventArgs e)
        {
            recorder.TakeSnapshot(link);
            LoadMultimedia();
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            Debug.WriteLine($"before stop {Utils.SizeOf(recorder)}");
            recorder.StopRecording();
            Debug.WriteLine($"after stop {Utils.SizeOf(recorder)}");

            recorder.Dispose();
            Debug.WriteLine($"after dispose {Utils.SizeOf(recorder)}");
            recorder = null;
        }

        //private void cbRozdzielczoscVideo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbRozdzielczoscVideo.SelectedIndex == 0)
        //    {
        //        videoCaptureApi = VideoCaptureAPIs.DSHOW;
        //        frameWidth = 640;
        //        frameHeight = 480;
        //    }
        //    else if (cbRozdzielczoscVideo.SelectedIndex == 1)
        //    {
        //        videoCaptureApi = VideoCaptureAPIs.ANY;
        //        frameWidth = 1280;
        //        frameHeight = 720;
        //    }
        //    else if (cbRozdzielczoscVideo.SelectedIndex == 2)
        //    {
        //        videoCaptureApi = VideoCaptureAPIs.ANY;
        //        frameWidth = 1920;
        //        frameHeight = 1080;
        //    }
        //}

        //private void cbFormatVideo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbFormatVideo.SelectedIndex == 0)
        //    {
        //        fourCC = FourCC.H265;
        //    }
        //    else if (cbFormatVideo.SelectedIndex == 1)
        //    {
        //        fourCC = FourCC.MPG4;
        //    }
        //    else if (cbFormatVideo.SelectedIndex == 2)
        //    {
        //        fourCC = FourCC.HEVC;
        //    }
        //}
        private void cbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCamera = cbCamera.SelectedIndex;

            if (recorder != null)
            {
                Debug.WriteLine($"before stop {Utils.SizeOf(recorder)}");
                recorder.StopRecording();
                Debug.WriteLine($"after stop {Utils.SizeOf(recorder)}");
                recorder.Dispose();
                recorder = null;
            }
            LoadSettings();
            recorder = new Recorder(selectedCamera, frameWidth, frameHeight, fps, pbRecorder, fourCC, videoCaptureApi);
            //recorder.StartRecording($"file{DateTime.Now.Ticks}.mp4");
        }

        public void GetAllConnectedCameras()
        {
            using (var sde = new SystemDeviceEnumerator())
            {
                var devices = sde.ListVideoInputDevice();
                foreach (var device in devices)
                {
                    cbCamera.Items.Add(device.Value);
                }
            }
            //using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE (PNPClass = 'Image' OR PNPClass = 'Camera')"))
            //{
            //    foreach (var device in searcher.Get())
            //    {
            //        cbCamera.Items.Add(device["Caption"].ToString());
            //    }
            //}

        }

        private Bitmap GetFrameFromVideo(string path)
        {
            VideoCapture _video = new VideoCapture(path);
            //_video.Set(VideoCaptureProperties.PosFrames, _video.FrameCount/2); //ustawia klatke wideo na po�owie filmu

            var ms = new MemoryStream();
            Mat mat = new Mat();
            _video.Read(mat);
            mat.Clone().ToMemoryStream(".png").CopyTo(ms);

            return new Bitmap(ms);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Thread.Sleep(300);
            tabControl1.Width = this.Width - tabControl1.Location.X;
            tabControl1.Height = this.Height;
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            var height = (int)(pbRecorder.Width * 0.5625);
            if (height >= pbRecorder.MinimumSize.Height) pbRecorder.Height = height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm(cbCamera.Text);
            if (settings.ShowDialog() == DialogResult.OK)
            {
                LoadSettings();
                RunRecorder();
            };
        }

        private void FormGrabber_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.WriteLine($"before stop {Utils.SizeOf(recorder)}");
            recorder.StopRecording();
            Debug.WriteLine($"after stop {Utils.SizeOf(recorder)}");

            recorder.Dispose();
            Debug.WriteLine($"after dispose {Utils.SizeOf(recorder)}");
            recorder = null;
        }

        public void DisplayPicture(string path)
        {
            tabControl1.SelectedTab = tabPicture;
            pbPicture.Image = new Bitmap(path);
        }

        public void DisplayVideo(string path)
        {
            tabControl1.SelectedTab = tabPlayer;
            var player = new VlcClient.PlayerControl(path);
            tabPlayer.Controls.Clear();
            tabPlayer.Controls.Add(player);
        }

        public void DisposeTabPlayer()
        {
            tabPlayer.Controls.Clear();
        }

        private void pbPicture_Resize(object sender, EventArgs e)
        {
            var height = (int)(pbRecorder.Width * 0.5625);
            if (height >= pbPicture.MinimumSize.Height) pbPicture.Height = height;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var control = flowLayoutPanel1.Controls;
            var listPath = new List<string>();
            foreach (var item in control) //wyci�ga �ciezki w zaznaczonych elementach
            {
                if (item is MultimediaControl mc)
                {
                    if (mc.IsChecked) listPath.Add(mc.Path);
                }
            }

            //TODO Co dalej z tymi �cie�kami?
            this.Close();
        }
    }
}