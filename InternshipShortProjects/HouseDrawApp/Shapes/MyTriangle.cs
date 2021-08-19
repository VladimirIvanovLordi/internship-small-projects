using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseDrawApp.Shapes
{
    public abstract class MyTriangle : Shape
    {
        protected Point TopPoint { get; set; }

        //contains the amount the top point of the triangle is offset from the top of the rectangle under it
        int topPointOffsetHeight = 70;
        //contains the amount the sides of the triangle are offset from the edges of the rectangle under it
        int sidePointOffset = 20;

        public MyTriangle(Brush brush, MyRectangle baseRectangle)
            :base(brush)
        {
            //calculates the three points of the triangle based on the center point of the rectangle under it
            TopPoint = new Point(baseRectangle.CenterPoint.X, baseRectangle.CenterPoint.Y + (baseRectangle.Height / 2) + topPointOffsetHeight);
            StartPoint = new Point(baseRectangle.CenterPoint.X - (baseRectangle.Width / 2) - sidePointOffset,
                baseRectangle.CenterPoint.Y + (baseRectangle.Height / 2));
            EndPoint = new Point(baseRectangle.CenterPoint.X + (baseRectangle.Width / 2) + sidePointOffset,
                baseRectangle.CenterPoint.Y + (baseRectangle.Height / 2));
        }

        //public override void DrawShape(Graphics graphics)
        //{
        //    Point[] points = { StartPoint, EndPoint, TopPoint };
        //    graphics.DrawPolygon(new Pen(BrushColor), points);
        //}
        public override abstract void DrawShape(Graphics graphics);
    }
}
