using HouseDrawApp.Shapes;

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


namespace HouseDrawApp
{
    [Serializable]
    public class House : ISerializable
    {
        private MyTriangle Roof { get; set; }
        private MyRectangle Body { get; set; }

        public House(MyTriangle roof, MyRectangle body)
        {
            Roof = roof;
            Body = body;
        }

        public void DrawHouse(Graphics graphics)
        {
            Roof.DrawShape(graphics);
            Body.DrawShape(graphics);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Roof", Roof);
            info.AddValue("Body", Body);
        }

        public House(SerializationInfo info, StreamingContext context)
        {
            Roof = (MyTriangle)info.GetValue("Roof", typeof(MyTriangle));
            Body = (MyRectangle)info.GetValue("Body", typeof(MyRectangle));
        }
    }
}
