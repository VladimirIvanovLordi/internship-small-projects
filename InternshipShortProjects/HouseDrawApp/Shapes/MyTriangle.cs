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
    public abstract class MyTriangle : Shape, ISerializable
    {
        protected Point TopPoint { get; set; }

        //contains the amount the top point of the triangle is offset from the top of the rectangle under it
        int topPointOffsetHeight = 100;
        //contains the amount the sides of the triangle are offset from the edges of the rectangle under it
        int sidePointOffset = 20;

        public MyTriangle(Brush brush, MyRectangle baseRectangle)
            :base(brush)
        {
            //calculates the three points of the triangle based on the center point of the rectangle under it
            TopPoint = new Point(baseRectangle.CenterPoint.X, baseRectangle.CenterPoint.Y - (baseRectangle.Height / 2) - topPointOffsetHeight);
            StartPoint = new Point(baseRectangle.CenterPoint.X - (baseRectangle.Width / 2) - sidePointOffset,
                baseRectangle.CenterPoint.Y - (baseRectangle.Height / 2));
            EndPoint = new Point(baseRectangle.CenterPoint.X + (baseRectangle.Width / 2) + sidePointOffset,
                baseRectangle.CenterPoint.Y - (baseRectangle.Height / 2));
        }

        //public override void DrawShape(Graphics graphics)
        //{
        //    Point[] points = { StartPoint, EndPoint, TopPoint };
        //    graphics.DrawPolygon(new Pen(BrushColor), points);
        //}
        public override abstract void DrawShape(Graphics graphics);

        new public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Start Point", StartPoint);
            info.AddValue("End Point", EndPoint);
            info.AddValue("Top Point", TopPoint);
            info.AddValue("Brush Color", BrushColor);

            info.AddValue("Side Point Offset", sidePointOffset);
            info.AddValue("Point Offset Height", topPointOffsetHeight);
        }

        public MyTriangle(SerializationInfo info, StreamingContext context)
            :base(info, context)
        {
            TopPoint = (Point)info.GetValue("Top Point", typeof(Point));

            sidePointOffset = (int)info.GetValue("Side Point Offset", typeof(int));
            topPointOffsetHeight = (int)info.GetValue("Point Offset Height", typeof(int));
        }
    }
}
