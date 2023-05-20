namespace WinFormsViewer
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
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            videoView2 = new LibVLCSharp.WinForms.VideoView();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videoView2).BeginInit();
            SuspendLayout();
            // 
            // videoView1
            // 
            videoView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            videoView1.BackColor = Color.Black;
            videoView1.Location = new Point(0, 0);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(927, 520);
            videoView1.TabIndex = 0;
            videoView1.Text = "videoView1";
            videoView1.Click += videoView1_Click;
            // 
            // videoView2
            // 
            videoView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            videoView2.BackColor = Color.Black;
            videoView2.Location = new Point(952, 0);
            videoView2.MediaPlayer = null;
            videoView2.Name = "videoView2";
            videoView2.Size = new Size(881, 520);
            videoView2.TabIndex = 1;
            videoView2.Text = "videoView2";
            videoView2.Click += videoView2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1833, 520);
            Controls.Add(videoView2);
            Controls.Add(videoView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)videoView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView1;
        private LibVLCSharp.WinForms.VideoView videoView2;
    }
}