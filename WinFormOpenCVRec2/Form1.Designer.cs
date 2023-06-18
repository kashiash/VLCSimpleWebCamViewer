namespace WinFormOpenCVRec2
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
            pictureBox1 = new PictureBox();
            buttonStart = new Button();
            buttonStop = new Button();
            buttonChangeCamera = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1980, 990);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 996);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(112, 34);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(130, 996);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(112, 34);
            buttonStop.TabIndex = 2;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonChangeCamera
            // 
            buttonChangeCamera.Location = new Point(270, 1000);
            buttonChangeCamera.Name = "buttonChangeCamera";
            buttonChangeCamera.Size = new Size(112, 34);
            buttonChangeCamera.TabIndex = 3;
            buttonChangeCamera.Text = "button1";
            buttonChangeCamera.UseVisualStyleBackColor = true;
            buttonChangeCamera.Click += buttonChangeCamera_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1980, 1204);
            Controls.Add(buttonChangeCamera);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonStart;
        private Button buttonStop;
        private Button buttonChangeCamera;
    }
}