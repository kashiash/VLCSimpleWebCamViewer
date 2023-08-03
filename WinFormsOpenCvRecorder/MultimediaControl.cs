using OpenCvSharp;
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
    public partial class MultimediaControl : UserControl
    {
        private Bitmap _ico;
        private Bitmap _miniatura;
        private FormGrabber _formGrabber;

        public MultimediaControl(Bitmap ico, Bitmap miniatura, string path, FormGrabber formGrabber)
        {
            InitializeComponent();
            _ico = ico;
            _miniatura = miniatura;
            checkBox1.Checked = true;
            Path = path;
            _formGrabber = formGrabber;
        }

        private void MultimediaControl_Load(object sender, EventArgs e)
        {
            pbIco.Image = _ico;
            pbMiniatura.Image = _miniatura;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            IsChecked = checkBox1.Checked;
        }
        public bool IsChecked { get; private set; }
        public string Path { get; private set; }
        public bool IsVideo { get; set; }
        public void Checked()
        {
            checkBox1.Checked = true;
        }
        public void Unchecked()
        {
            checkBox1.Checked = false;
        }
        private void SetBackColor(Color color)
        {
            this.BackColor = color;
        }
        private void MultimediaControl_Click(object sender, EventArgs e)
        {            
            if (IsVideo) _formGrabber.DisplayVideo(Path);
            else _formGrabber.DisplayPicture(Path);
            this.BackColor = Color.LightGray;
        }

        private void pbMiniatura_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.LightGray;
        }

        private void MultimediaControl_Leave(object sender, EventArgs e)
        {
            if (!IsVideo) _formGrabber.DisposeTabPlayer();
            this.BackColor = Color.FromArgb(255, 240, 240, 240);
        }

    }
}
