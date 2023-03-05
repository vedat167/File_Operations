using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileCreate_Click(object sender, EventArgs e)
        {
            string file = textBox1.Text; // getting file name from user
            Directory.CreateDirectory("C:\\Users\\vedat_new\\Desktop\\" + file); // create file in this local

        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            string file = textBox1.Text;
            Directory.Delete("C:\\Users\\vedat_new\\Desktop\\" + file); // delete file
        }

        private void btnFileControl_Click(object sender, EventArgs e)
        {
            string path = @"C:\\Users\\vedat_new\\Desktop\\deneme";
            MessageBox.Show(Directory.Exists(path).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\\Users\\vedat_new\\Desktop\\deneme";
            MessageBox.Show(Directory.GetCreationTime(path).ToString());
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetCurrentDirectory().ToString());
        }

        private void btnFileList_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files";
            string[] files = Directory.GetDirectories(path);
            foreach (string i in files)
            {
                listBox1.Items.Add(i.ToString());
            }

        }

        private void btnLastAccesstTime_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\vedat_new\Desktop\deneme";
            MessageBox.Show(Directory.GetLastAccessTime(path).ToString());
        }

        private void btnChangeFileName_Click(object sender, EventArgs e)
        {
            Directory.Move(@"C:\Users\vedat_new\Desktop\deneme", @"C:\Users\vedat_new\Desktop\deneme2");
        }
    }
}