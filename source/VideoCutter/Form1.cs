using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoCutter
{
    public partial class Form1 : Form
    {
    	List<Panel> timePanels;
    	
        public Form1()
        {
            InitializeComponent();
            timePanels = new List<Panel>();
            addPanelTime();
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] items = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string item in items)
            {
                textBox1.Text = item;
            }
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

		private void ButtonAddTimeClick(object sender, EventArgs e)
		{
			addPanelTime();
		}
		
		private void addPanelTime(){
        	// 
        	// panelFirstTime
        	// 
        	var panelTime = new Panel();
        	panelTime.Location = new Point(3, 3+(35*timePanels.Count));
        	panelTime.Name = "panelTime";
        	panelTime.Size = new Size(201, 35);
        	panelTime.TabIndex = 0;
			// 
        	// dtpInit
        	// 
        	var dtpInit = new DateTimePicker();
        	dtpInit.CustomFormat = "hh:mm:ss";
        	dtpInit.Format = DateTimePickerFormat.Time;
        	dtpInit.Location = new Point(3, 3);
        	dtpInit.Name = "dtpInit";
        	dtpInit.ShowUpDown = true;
        	dtpInit.Size = new Size(67, 20);
        	dtpInit.TabIndex = 2;
        	dtpInit.Value = new DateTime(2015, 8, 18, 0, 0, 0, 0);
        	// 
        	// dtpEnd
        	// 
        	var dtpEnd = new DateTimePicker();
        	dtpEnd.CustomFormat = "hh:mm:ss";
        	dtpEnd.Format = DateTimePickerFormat.Time;
        	dtpEnd.Location = new Point(98, 3);
        	dtpEnd.Name = "dtpEnd";
        	dtpEnd.ShowUpDown = true;
        	dtpEnd.Size = new Size(67, 20);
        	dtpEnd.TabIndex = 3;
        	dtpEnd.Value = new DateTime(2015, 8, 18, 0, 0, 0, 0);
        	// 
        	// lbTo
        	// 
        	var lbTo = new Label();
        	lbTo.AutoSize = true;
        	lbTo.Location = new System.Drawing.Point(76, 9);
        	lbTo.Name = "lbTo";
        	lbTo.Size = new System.Drawing.Size(16, 13);
        	lbTo.TabIndex = 4;
        	lbTo.Text = "to";
        	// 
        	// btnRemove
        	// 
        	var btnRemove = new Button();
        	btnRemove.Location = new Point(171, 3);
        	btnRemove.Name = "btnRemove";
        	btnRemove.Size = new Size(23, 23);
        	btnRemove.TabIndex = 5;
        	btnRemove.Text = "-";
        	btnRemove.UseVisualStyleBackColor = true;
        	// 
        	// panelTime
        	// 
        	panelTime.Controls.Add(btnRemove);
        	panelTime.Controls.Add(dtpInit);
        	panelTime.Controls.Add(dtpEnd);
        	panelTime.Controls.Add(lbTo);
        	panelTimes.Controls.Add(panelTime);
        	timePanels.Add(panelTime);
		}
		
		private void BtnSelectFfmpegClick(object sender, EventArgs e)
		{
			if (ofdFfMpeg.ShowDialog() == DialogResult.OK)
 			{
				tbFfmpegLocation.Text = ofdFfMpeg.FileName;
			}
		}
		
		private void BtnCutClick(object sender, EventArgs e)
		{
			foreach(var timePanel in timePanels){
        		DateTimePicker dtpInit =  timePanel.Controls.Find("dtpInit", true).FirstOrDefault() as DateTimePicker;
        		DateTimePicker dtpEnd =  timePanel.Controls.Find("dtpEnd", true).FirstOrDefault() as DateTimePicker;
	            string to = (dtpEnd.Value - dtpInit.Value).ToString();
	            string path = tbFfmpegLocation.Text;
	
	            string outputFolder = Path.GetDirectoryName(textBox1.Text);
	            Console.WriteLine(outputFolder);
	            if (outputFolder.Length != 3) outputFolder = outputFolder + "\\";
	            string output = dtpInit.Value.ToString().Substring(11).Replace(':', '-')+"_"+dtpEnd.Value.ToString().Substring(11).Replace(':', '-')+".mkv";
	           
		        string arguments = " -ss " + dtpInit.Value.ToString().Substring(11) + " -i \"" + textBox1.Text + "\" -to " + to + " -preset ultrafast -crf 23 -ac 2 " + "\"" + outputFolder + output + "\"";
		
		        var processStartInfo = new ProcessStartInfo(path, arguments);
		        var process = new Process();
		        process.StartInfo = processStartInfo;
		        process.Start();
		        process.WaitForExit();
        	}
		}
    }
}
