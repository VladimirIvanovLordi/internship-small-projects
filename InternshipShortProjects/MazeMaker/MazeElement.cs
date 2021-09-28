using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;


namespace MazeMaker
{
    [Serializable]
    public class MazeElement : ISerializable
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public MazeElement(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Location X", X);
            info.AddValue("Location Y", Y);
        }

        public MazeElement(SerializationInfo info, StreamingContext context)
        {
            X = (int)info.GetValue("Location X", typeof(int));
            Y = (int)info.GetValue("Location Y", typeof(int));
        }
    }
}
