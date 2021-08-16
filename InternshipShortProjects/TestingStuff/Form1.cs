using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingStuff
{
    public partial class Form1 : Form
    {
        string testFilesLocation = @"D:\Visual Studio Projects";

        public Form1()
        {
            InitializeComponent();
        }
        private void AddNumber_Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            tboxForNumber.Text += button.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter saveWriter = new StreamWriter(testFilesLocation + @"\TestFile.txt", true))
            {
                saveWriter.WriteLine(tboxForNumber.Text);
            }
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            using (StreamReader numbersReader = new StreamReader(testFilesLocation + @"\TestFile.txt"))
            {
                string fileInfo = numbersReader.ReadToEnd();
                tboxForNumber.Text += Environment.NewLine;
                tboxForNumber.Text += fileInfo;
            }
        }
    }
}
