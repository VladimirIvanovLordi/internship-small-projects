using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseDrawApp.Shapes
{
    public class EmptyRectangle : MyRectangle
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
