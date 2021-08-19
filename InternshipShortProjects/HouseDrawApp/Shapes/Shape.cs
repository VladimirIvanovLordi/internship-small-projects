using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HouseDrawApp.Shapes
{
    public abstract class Shape
    {
        protected Point StartPoint { get; set; }
        protected Point EndPoint { get; set; }
        public int Width 
        {
            get
            {
                return (EndPoint.X - StartPoint.X);
            }
        }
        public int Height
        {
            get
            {
                return Math.Abs(EndPoint.Y - StartPoint.Y);
            }
        }
        public Brush BrushColor { get; set; }

        public Shape(Brush brush)
        {
            BrushColor = brush;
        }

        public abstract void DrawShape(Graphics graphics);
    }
}
