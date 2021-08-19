using HouseDrawApp.Shapes;

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseDrawApp
{
    public partial class mainForm : Form
    {
        private List<Brush> brushes = new List<Brush>()
        {
            Brushes.Black,
            Brushes.Orange,
            Brushes.Red,
            Brushes.Aqua,
            Brushes.LightGreen,
            Brushes.Green,
            Brushes.Yellow,
            Brushes.Blue,
            Brushes.BurlyWood,
            Brushes.Brown,
            Brushes.Coral
        };
        private List<House> houses = new List<House>();
        //TODO add list to save and then redraw houses (maybe a list containing arrays-containing the rectangle and triangle)

        public mainForm()
        {
            InitializeComponent();
        }

        public void ReDraw()
        {
            Graphics graphics = drawPanel.CreateGraphics();
            graphics.Clear(Color.White);
            foreach (House house in houses)
            {
                house.DrawHouse(graphics);
            }
        }

        public Brush GetRandomBrush()
        {
            Random rendomBrushPicker = new Random();
            return brushes[rendomBrushPicker.Next(brushes.Count)];
        }

        private void drawPanel_Click(object sender, EventArgs e)
        {
            MyTriangle houseRoof;
            MyRectangle houseBody;
            if (radBtnEmptyRectangle.Checked)
            {
                houseBody = new EmptyRectangle(GetRandomBrush(), Cursor.Position);
            }
            else if (radBtnFilledRectangle.Checked)
            {
                houseBody = new FilledRectangle(GetRandomBrush(), Cursor.Position);
            }
            else
            {
                Random rectanglePicker = new Random();
                if (rectanglePicker.Next(2) == 0)
                {
                    houseBody = new EmptyRectangle(GetRandomBrush(), Cursor.Position);
                }
                else
                {
                    houseBody = new FilledRectangle(GetRandomBrush(), Cursor.Position);
                }
            }

            if (radBtnEmptyTriangle.Checked)
            {
                houseRoof = new EmptyTriangle(GetRandomBrush(), houseBody);
            }
            else if (radBtnFilledTriangle.Checked)
            {
                houseRoof = new FilledTriangle(GetRandomBrush(), houseBody);
            }
            else
            {
                Random trianglePicker = new Random();
                if (trianglePicker.Next(2) == 0)
                {
                    houseRoof = new EmptyTriangle(GetRandomBrush(), houseBody);
                }
                else
                {
                    houseRoof = new FilledTriangle(GetRandomBrush(), houseBody);
                }
            }

            House createdHouse = new House(houseRoof, houseBody);
            houses.Add(createdHouse);
            createdHouse.DrawHouse(drawPanel.CreateGraphics());
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            ReDraw();
        }

        private void btnClearRadio_Click(object sender, EventArgs e)
        {
            radBtnEmptyRectangle.Checked = false;
            radBtnEmptyTriangle.Checked = false;
            radBtnFilledRectangle.Checked = false;
            radBtnFilledTriangle.Checked = false;
        }


        //TODO clear the event from design and then from here if the issue is fixed
        private void drawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            //MyTriangle houseRoof;
            //MyRectangle houseBody;
            //if (radBtnEmptyRectangle.Checked)
            //{
            //    houseBody = new EmptyRectangle(GetRandomBrush(), new Point(e.X, e.Y));
            //}
            //else if (radBtnFilledRectangle.Checked)
            //{
            //    houseBody = new FilledRectangle(GetRandomBrush(), new Point(e.X, e.Y));
            //}
            //else
            //{
            //    Random rectanglePicker = new Random();
            //    if (rectanglePicker.Next(2) == 0)
            //    {
            //        houseBody = new EmptyRectangle(GetRandomBrush(), new Point(e.X, e.Y));
            //    }
            //    else
            //    {
            //        houseBody = new FilledRectangle(GetRandomBrush(), new Point(e.X, e.Y));
            //    }
            //}

            //if (radBtnEmptyTriangle.Checked)
            //{
            //    houseRoof = new EmptyTriangle(GetRandomBrush(), houseBody);
            //}
            //else if (radBtnFilledTriangle.Checked)
            //{
            //    houseRoof = new FilledTriangle(GetRandomBrush(), houseBody);
            //}
            //else
            //{
            //    Random trianglePicker = new Random();
            //    if (trianglePicker.Next(2) == 0)
            //    {
            //        houseRoof = new EmptyTriangle(GetRandomBrush(), houseBody);
            //    }
            //    else
            //    {
            //        houseRoof = new FilledTriangle(GetRandomBrush(), houseBody);
            //    }
            //}

            //House createdHouse = new House(houseRoof, houseBody);
            //houses.Add(createdHouse);
            //createdHouse.DrawHouse(drawPanel.CreateGraphics());
        }

        private void btnSaveInFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.FileName = "MyHouse.png";
            ImageFormat format = ImageFormat.Png;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                int width = drawPanel.ClientRectangle.Width;
                int height = drawPanel.ClientRectangle.Height;
                Bitmap bitmap = new Bitmap(width, height);
                drawPanel.DrawToBitmap(bitmap, new Rectangle(0, 0, width, height));
                switch (Path.GetExtension(saveFileDialog.FileName))
                {
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    default:
                        throw new Exception("Error in saving!");
                        break;
                }
                bitmap.Save(saveFileDialog.FileName, format);
            }
        }
    }
}
