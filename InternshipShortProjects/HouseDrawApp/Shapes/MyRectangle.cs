using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseDrawApp.Shapes
{
    public abstract class MyRectangle : Shape
    {
        public Point CenterPoint { get; protected set; }

        //contains the amount the starting/ending point is offset from the central point
        protected int pointOffsetWidth = 90;
        protected int pointOffsetHeight = 70;

        public MyRectangle(Brush brush, Point centerPoint)
            :base(brush)
        {
            CenterPoint = centerPoint;
            StartPoint = new Point(CenterPoint.X - pointOffsetWidth, CenterPoint.Y - pointOffsetHeight);
            EndPoint = new Point(CenterPoint.X + pointOffsetWidth, CenterPoint.Y + pointOffsetHeight);
        }

        //public override void DrawShape(Graphics graphics)
        //{
        //    graphics.DrawRectangle(new Pen(BrushColor), StartPoint.X, StartPoint.Y, Width, Height);
        //}
        public override abstract void DrawShape(Graphics graphics);
    }
}
