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
    public class EmptyRectangle : MyRectangle, ISerializable
    {
        public EmptyRectangle(Brush brush, Point centerPoint)
            :base(brush, centerPoint)
        {
        }

        public override void DrawShape(Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(BrushColor), StartPoint.X, StartPoint.Y, Width, Height);
        }
    }
}
