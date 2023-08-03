namespace WinFormsOpenCvRecorder
{
    partial class SettingsForm
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
            label2 = new Label();
            cbFormatVideo = new ComboBox();
            cbRozdzielczoscVideo = new ComboBox();
            label1 = new Label();
            cxbDefault = new CheckBox();
            numFPS = new NumericUpDown();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            cbSnap = new ComboBox();
            label5 = new Label();
            cbStop = new ComboBox();
            label4 = new Label();
            cbStart = new ComboBox();
            btnZapisz = new Button();
            ((System.ComponentModel.ISupportInitialize)numFPS).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 16);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 11;
            label2.Text = "Format Video";
            // 
            // cbFormatVideo
            // 
            cbFormatVideo.FormattingEnabled = true;
            cbFormatVideo.Location = new Point(188, 33);
            cbFormatVideo.Name = "cbFormatVideo";
            cbFormatVideo.Size = new Size(133, 23);
            cbFormatVideo.TabIndex = 10;
            // 
            // cbRozdzielczoscVideo
            // 
            cbRozdzielczoscVideo.FormattingEnabled = true;
            cbRozdzielczoscVideo.Items.AddRange(new object[] { "640 x 480 (VGA)", "1280 x 720 (HD)", "1920 x 1080 (FHD)" });
            cbRozdzielczoscVideo.Location = new Point(21, 34);
            cbRozdzielczoscVideo.Name = "cbRozdzielczoscVideo";
            cbRozdzielczoscVideo.Size = new Size(127, 23);
            cbRozdzielczoscVideo.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 8;
            label1.Text = "Rozdzielczość Video";
            // 
            // cxbDefault
            // 
            cxbDefault.AutoSize = true;
            cxbDefault.Location = new Point(128, 82);
            cxbDefault.Margin = new Padding(3, 2, 3, 2);
            cxbDefault.Name = "cxbDefault";
            cxbDefault.Size = new Size(177, 19);
            cxbDefault.TabIndex = 12;
            cxbDefault.Text = "Ustaw jako domyśną kamerę";
            cxbDefault.UseVisualStyleBackColor = true;
            // 
            // numFPS
            // 
            numFPS.Location = new Point(21, 82);
            numFPS.Margin = new Padding(3, 2, 3, 2);
            numFPS.Name = "numFPS";
            numFPS.Size = new Size(42, 23);
            numFPS.TabIndex = 13;
            numFPS.Value = new decimal(new int[] { 29, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 65);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 14;
            label3.Text = "FPS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbSnap);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbStop);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbStart);
            groupBox1.Location = new Point(21, 128);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(333, 132);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Skróty klawiszowe";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 94);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 20;
            label6.Text = "Przechwycenie klatki";
            // 
            // cbSnap
            // 
            cbSnap.FormattingEnabled = true;
            cbSnap.Location = new Point(167, 92);
            cbSnap.Margin = new Padding(3, 2, 3, 2);
            cbSnap.Name = "cbSnap";
            cbSnap.Size = new Size(133, 23);
            cbSnap.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 60);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 18;
            label5.Text = "Zakończenie nagrywania";
            // 
            // cbStop
            // 
            cbStop.FormattingEnabled = true;
            cbStop.Location = new Point(167, 58);
            cbStop.Margin = new Padding(3, 2, 3, 2);
            cbStop.Name = "cbStop";
            cbStop.Size = new Size(133, 23);
            cbStop.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 28);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 16;
            label4.Text = "Rozpoczęcie nagrywania";
            // 
            // cbStart
            // 
            cbStart.FormattingEnabled = true;
            cbStart.Location = new Point(167, 26);
            cbStart.Margin = new Padding(3, 2, 3, 2);
            cbStart.Name = "cbStart";
            cbStart.Size = new Size(133, 23);
            cbStart.TabIndex = 0;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(21, 286);
            btnZapisz.Margin = new Padding(3, 2, 3, 2);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(333, 26);
            btnZapisz.TabIndex = 16;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 320);
            Controls.Add(btnZapisz);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(numFPS);
            Controls.Add(cxbDefault);
            Controls.Add(label2);
            Controls.Add(cbFormatVideo);
            Controls.Add(cbRozdzielczoscVideo);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SettingsForm";
            Text = "SettingsForm";
            FormClosing += SettingsForm_FormClosing;
            Load += SettingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)numFPS).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cbFormatVideo;
        private ComboBox cbRozdzielczoscVideo;
        private Label label1;
        private CheckBox cxbDefault;
        private NumericUpDown numFPS;
        private Label label3;
        private GroupBox groupBox1;
        private Label label6;
        private ComboBox cbSnap;
        private Label label5;
        private ComboBox cbStop;
        private Label label4;
        private ComboBox cbStart;
        private Button btnZapisz;
    }
}