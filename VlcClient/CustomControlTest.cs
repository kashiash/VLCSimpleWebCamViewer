using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VlcClient
{
    public partial class CustomControlTest : Form
    {
        string filePath;
        public CustomControlTest(string filePath)
        {
            this.filePath = filePath;
            InitializeComponent();


            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(videoView1.ShortcutEvent);
        }
    }
}
