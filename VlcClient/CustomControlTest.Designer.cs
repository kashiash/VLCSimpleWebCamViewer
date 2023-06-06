namespace VlcClient
{
    partial class CustomControlTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            videoView1 = new PlayerControl();
            videoView2 = new PlayerControl();

            SuspendLayout();
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.Black;
            videoView1.Location = new Point(0, 0);
            videoView1.Dock = DockStyle.Top;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(380, 200);
            videoView1.TabIndex = 0;
            videoView1.Text = "videoView1";

            videoView2.BackColor = Color.Black;
            videoView2.Location = new Point(0, 201);
            videoView2.Dock = DockStyle.Bottom;
            videoView2.Name = "videoView2";
            videoView2.Size = new Size(380, 200);
            videoView2.TabIndex = 0;
            videoView2.Text = "videoView2";
            // 
            // CustomControlTest
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 652);
            Controls.Add(videoView1);
            Name = "CustomControlTest";
            Text = "CustomControlTest";
   
            ResumeLayout(false);
        }

        #endregion

        private PlayerControl videoView1;
        private PlayerControl videoView2;
    }
}