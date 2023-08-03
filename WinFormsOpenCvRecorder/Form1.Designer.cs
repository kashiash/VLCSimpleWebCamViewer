namespace WinFormsOpenCvRecorder
{
    partial class FormGrabber
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
            pbRecorder = new PictureBox();
            buttonStart = new Button();
            buttonStop = new Button();
            buttonTakeSnapshot = new Button();
            cbCamera = new ComboBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            btnConfirm = new Button();
            tabControl1 = new TabControl();
            tabRecorder = new TabPage();
            tabPlayer = new TabPage();
            tabPicture = new TabPage();
            pbPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbRecorder).BeginInit();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabRecorder.SuspendLayout();
            tabPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            SuspendLayout();
            // 
            // pbRecorder
            // 
            pbRecorder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbRecorder.Location = new Point(20, 5);
            pbRecorder.Margin = new Padding(2);
            pbRecorder.MinimumSize = new Size(640, 380);
            pbRecorder.Name = "pbRecorder";
            pbRecorder.Size = new Size(640, 435);
            pbRecorder.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRecorder.TabIndex = 0;
            pbRecorder.TabStop = false;
            pbRecorder.Resize += pictureBox1_Resize;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(11, 731);
            buttonStart.Margin = new Padding(2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(78, 32);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(93, 731);
            buttonStop.Margin = new Padding(2);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(78, 32);
            buttonStop.TabIndex = 2;
            buttonStop.Text = "STOP";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonTakeSnapshot
            // 
            buttonTakeSnapshot.Image = Properties.Resources.screenshot_32;
            buttonTakeSnapshot.Location = new Point(175, 722);
            buttonTakeSnapshot.Margin = new Padding(2);
            buttonTakeSnapshot.Name = "buttonTakeSnapshot";
            buttonTakeSnapshot.Size = new Size(55, 40);
            buttonTakeSnapshot.TabIndex = 3;
            buttonTakeSnapshot.UseVisualStyleBackColor = true;
            buttonTakeSnapshot.Click += buttonTakeSnapshot_Click;
            // 
            // cbCamera
            // 
            cbCamera.FormattingEnabled = true;
            cbCamera.Location = new Point(117, 25);
            cbCamera.Name = "cbCamera";
            cbCamera.Size = new Size(218, 23);
            cbCamera.TabIndex = 8;
            cbCamera.SelectedIndexChanged += cbCamera_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 27);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 9;
            label3.Text = "Urządzenie";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Location = new Point(21, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 665);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Multimedia";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(14, 30);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(393, 618);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.settings_824700;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(340, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(54, 46);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(319, 726);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(117, 33);
            btnConfirm.TabIndex = 12;
            btnConfirm.Text = "Zatwierdź";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabRecorder);
            tabControl1.Controls.Add(tabPlayer);
            tabControl1.Controls.Add(tabPicture);
            tabControl1.Location = new Point(452, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(698, 762);
            tabControl1.TabIndex = 13;
            // 
            // tabRecorder
            // 
            tabRecorder.Controls.Add(pbRecorder);
            tabRecorder.Location = new Point(4, 24);
            tabRecorder.Name = "tabRecorder";
            tabRecorder.Padding = new Padding(3);
            tabRecorder.Size = new Size(690, 734);
            tabRecorder.TabIndex = 0;
            tabRecorder.Text = "Recorder";
            tabRecorder.UseVisualStyleBackColor = true;
            // 
            // tabPlayer
            // 
            tabPlayer.Location = new Point(4, 24);
            tabPlayer.Name = "tabPlayer";
            tabPlayer.Padding = new Padding(3);
            tabPlayer.Size = new Size(690, 734);
            tabPlayer.TabIndex = 1;
            tabPlayer.Text = "Player";
            tabPlayer.UseVisualStyleBackColor = true;
            // 
            // tabPicture
            // 
            tabPicture.Controls.Add(pbPicture);
            tabPicture.Location = new Point(4, 24);
            tabPicture.Name = "tabPicture";
            tabPicture.Padding = new Padding(3);
            tabPicture.Size = new Size(690, 734);
            tabPicture.TabIndex = 2;
            tabPicture.Text = "Picture";
            tabPicture.UseVisualStyleBackColor = true;
            // 
            // pbPicture
            // 
            pbPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbPicture.Location = new Point(6, 6);
            pbPicture.MinimumSize = new Size(640, 480);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(640, 480);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 0;
            pbPicture.TabStop = false;
            pbPicture.Resize += pbPicture_Resize;
            // 
            // FormGrabber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 774);
            Controls.Add(tabControl1);
            Controls.Add(btnConfirm);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(cbCamera);
            Controls.Add(groupBox1);
            Controls.Add(buttonTakeSnapshot);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Margin = new Padding(2);
            MinimumSize = new Size(1178, 813);
            Name = "FormGrabber";
            Text = "Grabber Video";
            FormClosing += FormGrabber_FormClosing;
            Load += Form1_Load;
            Leave += Form1_Leave;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)pbRecorder).EndInit();
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabRecorder.ResumeLayout(false);
            tabPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbRecorder;
        private Button buttonStart;
        private Button buttonStop;
        private Button buttonTakeSnapshot;
        private ComboBox cbCamera;
        private Label label3;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button btnConfirm;
        private TabControl tabControl1;
        private TabPage tabRecorder;
        private TabPage tabPlayer;
        private TabPage tabPicture;
        private PictureBox pbPicture;
    }
}