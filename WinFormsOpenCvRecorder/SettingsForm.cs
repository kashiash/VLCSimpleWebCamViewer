using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsOpenCvRecorder
{
    public partial class SettingsForm : Form
    {
        private string _cameraName { get; set; }
        public SettingsForm(string CameraName)
        {
            InitializeComponent();
            _cameraName = CameraName;
            this.Text = $"Ustawienia: {CameraName}";
            cbStart.DataSource = Enum.GetValues(typeof(Shortcut));
            cbStop.DataSource = Enum.GetValues(typeof(Shortcut));
            cbSnap.DataSource = Enum.GetValues(typeof(Shortcut));
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.ApplicationSettings))
            {
                cbFormatVideo.SelectedIndex = 0;
                cbRozdzielczoscVideo.SelectedIndex = 0;
                numFPS.Value = 30;
            }
            else
            {
                var settings = JsonConvert.DeserializeObject<List<CameraSettings>>(Properties.Settings.Default.ApplicationSettings);
                var setting = settings.Where(x => x.CameraName == _cameraName).FirstOrDefault();
                cbFormatVideo.SelectedItem = setting.FormatVideo;
                cbRozdzielczoscVideo.SelectedItem = setting.RozdzielczoscVideo;
                cxbDefault.Checked = setting.Default;
                numFPS.Value = setting.FPS;
                cbStart.SelectedItem = setting.Start;
                cbStop.SelectedItem = setting.Stop;
                cbSnap.SelectedItem = setting.Snap;
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.ApplicationSettings))
            {
                var settings = new List<CameraSettings>();
                settings.Add(new CameraSettings()
                {
                    CameraName = _cameraName,
                    FormatVideo = cbFormatVideo.SelectedItem.ToString(),
                    RozdzielczoscVideo = cbRozdzielczoscVideo.SelectedItem.ToString(),
                    Default = cxbDefault.Checked,
                    FPS = (int)numFPS.Value,
                    Start = (Shortcut)cbStart.SelectedItem,
                    Stop = (Shortcut)cbStop.SelectedItem,
                    Snap = (Shortcut)cbSnap.SelectedItem
                });

                Properties.Settings.Default.ApplicationSettings = JsonConvert.SerializeObject(settings);
                Properties.Settings.Default.Save();
            }
            else
            {
                var settings = JsonConvert.DeserializeObject<List<CameraSettings>>(Properties.Settings.Default.ApplicationSettings);
                var setting = settings.Where(x => x.CameraName == _cameraName).FirstOrDefault();
                setting.FormatVideo = cbFormatVideo.SelectedItem.ToString();
                setting.RozdzielczoscVideo = cbRozdzielczoscVideo.SelectedItem.ToString();
                setting.Default = cxbDefault.Checked;
                setting.FPS = (int)numFPS.Value;
                setting.Start = (Shortcut)cbStart.SelectedItem;
                setting.Stop = (Shortcut)cbStop.SelectedItem;
                setting.Snap = (Shortcut)cbSnap.SelectedItem;

                Properties.Settings.Default.ApplicationSettings = JsonConvert.SerializeObject(settings);
                Properties.Settings.Default.Save();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
