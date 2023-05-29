namespace VlcClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            vlcControl = new LibVLCSharp.WinForms.VideoView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            trackBar1 = new TrackBar();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)vlcControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // vlcControl
            // 
            vlcControl.BackColor = Color.Black;
            vlcControl.Dock = DockStyle.Top;
            vlcControl.Location = new Point(0, 0);
            vlcControl.MediaPlayer = null;
            vlcControl.Name = "vlcControl";
            vlcControl.Size = new Size(2287, 1375);
            vlcControl.TabIndex = 0;
            vlcControl.Text = "vlcControl";
            vlcControl.MouseDown += vlcControl_MouseDown;
            vlcControl.MouseMove += vlcControl_MouseMove;
            vlcControl.MouseUp += vlcControl_MouseUp;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 1394);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 1394);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(0, 1431);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(2287, 69);
            trackBar1.TabIndex = 3;
            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(369, 1394);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(558, 1398);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2287, 1501);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(trackBar1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(vlcControl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)vlcControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LibVLCSharp.WinForms.VideoView vlcControl;
        private TextBox textBox1;
        private TextBox textBox2;
        private TrackBar trackBar1;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}