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
    public class Wall : MazeElement, ISerializable
    {
        public Wall(int x, int y)
            :base(x, y)
        {

        }
    }
}
