using HouseDrawApp.Shapes;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HouseDrawApp
{
    public class House
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
    }
}
