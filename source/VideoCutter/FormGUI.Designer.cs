namespace VideoCutter
{
    partial class FormGUI
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGUI));
        	this.btnCut = new System.Windows.Forms.Button();
        	this.label2 = new System.Windows.Forms.Label();
        	this.labelFfmpeg = new System.Windows.Forms.Label();
        	this.tbFfmpegLocation = new System.Windows.Forms.TextBox();
        	this.ofdFile = new System.Windows.Forms.OpenFileDialog();
        	this.btnSelectFfmpeg = new System.Windows.Forms.Button();
        	this.buttonAddTime = new System.Windows.Forms.Button();
        	this.panelTimes = new System.Windows.Forms.Panel();
        	this.tbVideoLocation = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.btnSelectVideo = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// btnCut
        	// 
        	this.btnCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnCut.Location = new System.Drawing.Point(328, 208);
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
        	this.label2.Location = new System.Drawing.Point(12, 218);
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
        	this.tbFfmpegLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.tbFfmpegLocation.Enabled = false;
        	this.tbFfmpegLocation.Location = new System.Drawing.Point(118, 9);
        	this.tbFfmpegLocation.Name = "tbFfmpegLocation";
        	this.tbFfmpegLocation.Size = new System.Drawing.Size(204, 20);
        	this.tbFfmpegLocation.TabIndex = 8;
        	// 
        	// ofdFile
        	// 
        	this.ofdFile.FileName = "ofdFfMpeg";
        	// 
        	// btnSelectFfmpeg
        	// 
        	this.btnSelectFfmpeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnSelectFfmpeg.Location = new System.Drawing.Point(328, 7);
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
        	this.buttonAddTime.Location = new System.Drawing.Point(380, 73);
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
        	this.panelTimes.Location = new System.Drawing.Point(12, 102);
        	this.panelTimes.Name = "panelTimes";
        	this.panelTimes.Size = new System.Drawing.Size(391, 97);
        	this.panelTimes.TabIndex = 12;
        	// 
        	// tbVideoLocation
        	// 
        	this.tbVideoLocation.AllowDrop = true;
        	this.tbVideoLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.tbVideoLocation.Enabled = false;
        	this.tbVideoLocation.Location = new System.Drawing.Point(118, 44);
        	this.tbVideoLocation.Name = "tbVideoLocation";
        	this.tbVideoLocation.Size = new System.Drawing.Size(204, 20);
        	this.tbVideoLocation.TabIndex = 0;
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(12, 44);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(100, 20);
        	this.label1.TabIndex = 13;
        	this.label1.Text = "Video Location:";
        	this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// btnSelectVideo
        	// 
        	this.btnSelectVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnSelectVideo.Location = new System.Drawing.Point(328, 44);
        	this.btnSelectVideo.Name = "btnSelectVideo";
        	this.btnSelectVideo.Size = new System.Drawing.Size(75, 23);
        	this.btnSelectVideo.TabIndex = 14;
        	this.btnSelectVideo.Text = "Select";
        	this.btnSelectVideo.UseVisualStyleBackColor = true;
        	this.btnSelectVideo.Click += new System.EventHandler(this.BtnSelectVideoClick);
        	// 
        	// FormGUI
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(415, 240);
        	this.Controls.Add(this.btnSelectVideo);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.btnCut);
        	this.Controls.Add(this.panelTimes);
        	this.Controls.Add(this.buttonAddTime);
        	this.Controls.Add(this.btnSelectFfmpeg);
        	this.Controls.Add(this.tbFfmpegLocation);
        	this.Controls.Add(this.labelFfmpeg);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.tbVideoLocation);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "FormGUI";
        	this.Text = "VideoCutter";
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFfmpeg;
        private System.Windows.Forms.TextBox tbFfmpegLocation;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Button btnSelectFfmpeg;
        private System.Windows.Forms.Button buttonAddTime;
        private System.Windows.Forms.Panel panelTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectVideo;
        private System.Windows.Forms.TextBox tbVideoLocation;
    }
}

