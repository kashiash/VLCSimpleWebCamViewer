namespace WinFormsOpenCvRecorder
{
    partial class MultimediaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox1 = new CheckBox();
            pbMiniatura = new PictureBox();
            pbIco = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbMiniatura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIco).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(28, 28);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 0;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pbMiniatura
            // 
            pbMiniatura.Location = new Point(107, 28);
            pbMiniatura.Name = "pbMiniatura";
            pbMiniatura.Size = new Size(196, 154);
            pbMiniatura.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMiniatura.TabIndex = 1;
            pbMiniatura.TabStop = false;
            // 
            // pbIco
            // 
            pbIco.Location = new Point(18, 53);
            pbIco.Name = "pbIco";
            pbIco.Size = new Size(39, 35);
            pbIco.SizeMode = PictureBoxSizeMode.StretchImage;
            pbIco.TabIndex = 2;
            pbIco.TabStop = false;
            // 
            // MultimediaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pbIco);
            Controls.Add(pbMiniatura);
            Controls.Add(checkBox1);
            Name = "MultimediaControl";
            Size = new Size(310, 200);
            Load += MultimediaControl_Load;
            ((System.ComponentModel.ISupportInitialize)pbMiniatura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private PictureBox pbMiniatura;
        private PictureBox pbIco;
    }
}
