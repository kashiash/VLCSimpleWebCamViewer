namespace WinFormsOpenCvRecorder
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRozdzielczoscVideo = new System.Windows.Forms.ComboBox();
            this.cbFormatVideo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1332, 614);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 632);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 632);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::WinFormsOpenCvRecorder.Properties.Resources.screenshot_32;
            this.button3.Location = new System.Drawing.Point(172, 623);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 40);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rozdzielczość Video";
            // 
            // cbRozdzielczoscVideo
            // 
            this.cbRozdzielczoscVideo.FormattingEnabled = true;
            this.cbRozdzielczoscVideo.Items.AddRange(new object[] {
            "640 x 480 (VGA)",
            "1280 x 720 (HD)",
            "1920 x 1080 (FHD)"});
            this.cbRozdzielczoscVideo.Location = new System.Drawing.Point(301, 641);
            this.cbRozdzielczoscVideo.Name = "cbRozdzielczoscVideo";
            this.cbRozdzielczoscVideo.Size = new System.Drawing.Size(112, 23);
            this.cbRozdzielczoscVideo.TabIndex = 5;
            this.cbRozdzielczoscVideo.SelectedIndexChanged += new System.EventHandler(this.cbRozdzielczoscVideo_SelectedIndexChanged);
            // 
            // cbFormatVideo
            // 
            this.cbFormatVideo.FormattingEnabled = true;
            this.cbFormatVideo.Items.AddRange(new object[] {
            "H265",
            "MPG4",
            "HEVC"});
            this.cbFormatVideo.Location = new System.Drawing.Point(491, 641);
            this.cbFormatVideo.Name = "cbFormatVideo";
            this.cbFormatVideo.Size = new System.Drawing.Size(121, 23);
            this.cbFormatVideo.TabIndex = 6;
            this.cbFormatVideo.SelectedIndexChanged += new System.EventHandler(this.cbFormatVideo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Format Video";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 683);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFormatVideo);
            this.Controls.Add(this.cbRozdzielczoscVideo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private ComboBox cbRozdzielczoscVideo;
        private ComboBox cbFormatVideo;
        private Label label2;
    }
}