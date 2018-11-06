namespace VideoCutter
{
    partial class Form1
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        	this.btnCut = new System.Windows.Forms.Button();
        	this.label2 = new System.Windows.Forms.Label();
        	this.labelFfmpeg = new System.Windows.Forms.Label();
        	this.tbFfmpegLocation = new System.Windows.Forms.TextBox();
        	this.ofdFfMpeg = new System.Windows.Forms.OpenFileDialog();
        	this.btnSelectFfmpeg = new System.Windows.Forms.Button();
        	this.buttonAddTime = new System.Windows.Forms.Button();
        	this.panelTimes = new System.Windows.Forms.Panel();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.SuspendLayout();
        	// 
        	// btnCut
        	// 
        	this.btnCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnCut.Location = new System.Drawing.Point(612, 310);
        	this.btnCut.Name = "btnCut";
        	this.btnCut.Size = new System.Drawing.Size(75, 23);
        	this.btnCut.TabIndex = 1;
        	this.btnCut.Text = "Cut";
        	this.btnCut.UseVisualStyleBackColor = true;
        	this.btnCut.Click += new System.EventHandler(this.BtnCutClick);
        	// 
        	// label2
        	// 
        	this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(12, 320);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(31, 13);
        	this.label2.TabIndex = 6;
        	this.label2.Text = "0.0.1";
        	// 
        	// labelFfmpeg
        	// 
        	this.labelFfmpeg.Location = new System.Drawing.Point(12, 9);
        	this.labelFfmpeg.Name = "labelFfmpeg";
        	this.labelFfmpeg.Size = new System.Drawing.Size(100, 20);
        	this.labelFfmpeg.TabIndex = 7;
        	this.labelFfmpeg.Text = "FFMPEG Location:";
        	this.labelFfmpeg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// tbFfmpegLocation
        	// 
        	this.tbFfmpegLocation.Location = new System.Drawing.Point(118, 9);
        	this.tbFfmpegLocation.Name = "tbFfmpegLocation";
        	this.tbFfmpegLocation.Size = new System.Drawing.Size(488, 20);
        	this.tbFfmpegLocation.TabIndex = 8;
        	// 
        	// ofdFfMpeg
        	// 
        	this.ofdFfMpeg.FileName = "ofdFfMpeg";
        	// 
        	// btnSelectFfmpeg
        	// 
        	this.btnSelectFfmpeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnSelectFfmpeg.Location = new System.Drawing.Point(612, 7);
        	this.btnSelectFfmpeg.Name = "btnSelectFfmpeg";
        	this.btnSelectFfmpeg.Size = new System.Drawing.Size(75, 23);
        	this.btnSelectFfmpeg.TabIndex = 9;
        	this.btnSelectFfmpeg.Text = "Select";
        	this.btnSelectFfmpeg.UseVisualStyleBackColor = true;
        	this.btnSelectFfmpeg.Click += new System.EventHandler(this.BtnSelectFfmpegClick);
        	// 
        	// buttonAddTime
        	// 
        	this.buttonAddTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.buttonAddTime.Location = new System.Drawing.Point(664, 139);
        	this.buttonAddTime.Name = "buttonAddTime";
        	this.buttonAddTime.Size = new System.Drawing.Size(23, 23);
        	this.buttonAddTime.TabIndex = 11;
        	this.buttonAddTime.Text = "+";
        	this.buttonAddTime.UseVisualStyleBackColor = true;
        	this.buttonAddTime.Click += new System.EventHandler(this.ButtonAddTimeClick);
        	// 
        	// panelTimes
        	// 
        	this.panelTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.panelTimes.AutoScroll = true;
        	this.panelTimes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.panelTimes.Location = new System.Drawing.Point(12, 168);
        	this.panelTimes.Name = "panelTimes";
        	this.panelTimes.Size = new System.Drawing.Size(675, 133);
        	this.panelTimes.TabIndex = 12;
        	// 
        	// textBox1
        	// 
        	this.textBox1.AllowDrop = true;
        	this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.textBox1.Location = new System.Drawing.Point(12, 44);
        	this.textBox1.Multiline = true;
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(675, 89);
        	this.textBox1.TabIndex = 0;
        	this.textBox1.Text = "C:\\Users\\Guilherme\\Videos\\28.Dias\\28.Dias.mkv";
        	this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
        	this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(699, 342);
        	this.Controls.Add(this.btnCut);
        	this.Controls.Add(this.panelTimes);
        	this.Controls.Add(this.buttonAddTime);
        	this.Controls.Add(this.btnSelectFfmpeg);
        	this.Controls.Add(this.tbFfmpegLocation);
        	this.Controls.Add(this.labelFfmpeg);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.textBox1);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "Form1";
        	this.Text = "VideoCutter";
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFfmpeg;
        private System.Windows.Forms.TextBox tbFfmpegLocation;
        private System.Windows.Forms.OpenFileDialog ofdFfMpeg;
        private System.Windows.Forms.Button btnSelectFfmpeg;
        private System.Windows.Forms.Button buttonAddTime;
        private System.Windows.Forms.Panel panelTimes;
    }
}

