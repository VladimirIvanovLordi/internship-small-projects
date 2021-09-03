﻿using System;
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
    public class FilledTriangle : MyTriangle, ISerializable
    {
        public FilledTriangle(Brush brush, MyRectangle baseRectangle)
            :base(brush, baseRectangle)
        {
        }

        public override void DrawShape(Graphics graphics)
        {
            Point[] points = { StartPoint, EndPoint, TopPoint };
            graphics.FillPolygon(BrushColor, points);
        }
    }
}
