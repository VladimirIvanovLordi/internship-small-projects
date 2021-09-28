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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace MazeMaker
{
    /// <summary>
    /// Create a maze application in WinForms.
    /// A maze is a matrix of N x M elements where each element can be: start point (only one), end point (only one), wall, or path.
    /// The app should allow users to create visually mazes, save and load them.
    /// The app should have a function to find and display the shortest path from the start to the end point.
    /// </summary>

    public partial class MainForm : Form
    {
        Maze testMaze = new Maze(4, 5);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = ".txt";
                saveFileDialog.FileName = "Maze.txt";

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Maze));
                using (Stream saveStream = saveFileDialog.OpenFile())
                {
                    xmlSerializer.Serialize(saveStream, testMaze);
                }
            }
        }
    }
}
