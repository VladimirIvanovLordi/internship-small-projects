using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseDrawApp.Shapes
{
    public class EmptyTriangle : MyTriangle
    {
        public EmptyTriangle(Brush brush, MyRectangle baseRectangle)
            :base(brush, baseRectangle)
        {
        }

        public override void DrawShape(Graphics graphics)
        {
            Point[] points = { StartPoint, EndPoint, TopPoint };
            graphics.DrawPolygon(new Pen(BrushColor), points);
        }
    }
}
