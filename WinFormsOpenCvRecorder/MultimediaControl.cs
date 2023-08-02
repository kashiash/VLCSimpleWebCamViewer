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

        public MultimediaControl(Bitmap ico, Bitmap miniatura)
        {
            InitializeComponent();
            _ico = ico;
            _miniatura = miniatura;
            checkBox1.Checked = true;
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
        public void Checked()
        {
            checkBox1.Checked = true;
        }
        public void Unchecked()
        {
            checkBox1.Checked = false;
        }
    }
}
