using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace HouseDrawApp.Shapes
{
    [Serializable]
    public abstract class MyRectangle : Shape, ISerializable
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

        new public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Start Point", StartPoint);
            info.AddValue("End Point", EndPoint);
            info.AddValue("Center Point", CenterPoint);
            info.AddValue("Brush Color", BrushColor);

            info.AddValue("X offset", pointOffsetWidth);
            info.AddValue("Y offset", pointOffsetHeight);
        }

        public MyRectangle(SerializationInfo info, StreamingContext context)
            :base(info, context)
        {
            CenterPoint = (Point)info.GetValue("Center Point", typeof(Point));

            pointOffsetWidth = (int)info.GetValue("X offset", typeof(int));
            pointOffsetHeight = (int)info.GetValue("Y offset", typeof(int));

        }
    }
}
