using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Deleter
{
    public partial class dTextEditor : Form
    {
        public dTextEditor()
        {
            InitializeComponent();
        }
        
        public string line;
        public string _FullPathNameOnMainWindows;
        public string _StatusStripMainSizeFile;
        public string _StatusStripMainNameFile;
        
        public static string GetTextOnTextPath(string tFullPath)
        {
            string line;
            StreamReader sReader = new StreamReader(tFullPath);
            line = sReader.ReadToEnd();
            sReader.Close();
            return line;
        }

        public void getS()
        {
            textBox1.Text = GetTextOnTextPath(_FullPathNameOnMainWindows);
            StatusStripMainSizeFile.Text ="Размер файла: "+ _StatusStripMainSizeFile;
            StatusStripMainNameFile.Text = "Имя файла: " + _StatusStripMainNameFile;
            StatusStripMainNameFile.LinkBehavior = LinkBehavior.SystemDefault;
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            //textBox1.TextLength = StatusStripMainLenghtText.Text;
            StatusStripMainLenghtText.Text = "Символов: "+textBox1.TextLength.ToString();
            
        }

        private void ToolStripMainButFileOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = GetTextOnTextPath(openFileDialog1.FileName);
            }
        }

        private void StatusStripMainNameFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe", @"/select," +
                _FullPathNameOnMainWindows.Remove(_FullPathNameOnMainWindows.LastIndexOf('\\')));
        }
    }
}
