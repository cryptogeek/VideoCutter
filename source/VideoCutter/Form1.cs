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
        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string to = (dateTimePicker2.Value - dateTimePicker1.Value).ToString();

            string path = Path.Combine(Path.GetTempPath(), "ffmpeg.exe");

            string outputFolder = Path.GetDirectoryName(textBox1.Text);
            Console.WriteLine(outputFolder);
            if (outputFolder.Length != 3) outputFolder = outputFolder + "\\";
            string output;
            int i = 10000;
            do{
                output =  i + ".mp4";
                i++;
            } while (File.Exists(outputFolder + "\\"+ output));

            Console.WriteLine(outputFolder + output);
            Process compiler = new Process();
            compiler.StartInfo.FileName = path;
            Console.WriteLine(" -ss " + dateTimePicker1.Value.ToString().Substring(16) + " -i \"" + textBox1.Text + "\" -to " + to + " -preset ultrafast -crf 23 -ac 2 " + "\"" + outputFolder + output + "\"");
            compiler.StartInfo.Arguments = " -ss " + dateTimePicker1.Value.ToString().Substring(16) + " -i \"" + textBox1.Text + "\" -to " + to + " -preset ultrafast -crf 23 -ac 2 " + "\"" + outputFolder + output + "\"";
            compiler.StartInfo.UseShellExecute = false;
            compiler.StartInfo.RedirectStandardOutput = false;
            compiler.StartInfo.CreateNoWindow = false;
            compiler.Start();

            //compiler.WaitForExit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetTempPath(), "ffmpeg.exe");
            File.WriteAllBytes(path, VideoCutter.Properties.Resources.ffmpeg);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = Path.Combine(Path.GetTempPath(), "ffmpeg.exe"); 
            File.Delete(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value;
        }

    }
}
