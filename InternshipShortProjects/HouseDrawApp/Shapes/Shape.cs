using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace HouseDrawApp.Shapes
{
    [Serializable]
    public abstract class Shape : ISerializable
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Start Point", StartPoint);
            info.AddValue("End Point", EndPoint);
            info.AddValue("Brush Color", BrushColor);
        }

        public Shape(SerializationInfo info, StreamingContext context)
        {
            StartPoint = (Point)info.GetValue("Start Point", typeof(Point));
            EndPoint = (Point)info.GetValue("End Point", typeof(Point));
            BrushColor = (Brush)info.GetValue("Brush Color", typeof(Brush));
        }
    }
}
