namespace WebCamRecorderVlc
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
            videoOutput = new Panel();
            videoView = new LibVLCSharp.WinForms.VideoView();
            ((System.ComponentModel.ISupportInitialize)videoView).BeginInit();
            SuspendLayout();
            // 
            // videoOutput
            // 
            videoOutput.Location = new Point(12, 367);
            videoOutput.Name = "videoOutput";
            videoOutput.Size = new Size(503, 71);
            videoOutput.TabIndex = 0;
            // 
            // videoView
            // 
            videoView.BackColor = Color.Black;
            videoView.Location = new Point(24, 28);
            videoView.MediaPlayer = null;
            videoView.Name = "videoView";
            videoView.Size = new Size(764, 333);
            videoView.TabIndex = 1;
            videoView.Text = "videoView1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(videoView);
            Controls.Add(videoOutput);
            Name = "Form1";
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)videoView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel videoOutput;
        private LibVLCSharp.WinForms.VideoView videoView;
    }
}