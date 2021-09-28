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
    /// <summary>
    /// Create a maze application in WinForms.
    /// A maze is a matrix of N x M elements where each element can be: start point (only one), end point (only one), wall, or path.
    /// The app should allow users to create visually mazes, save and load them.
    /// The app should have a function to find and display the shortest path from the start to the end point.
    /// </summary>

    [Serializable]
    public class Maze : ISerializable
    {

        MazeElement[,] mazeGrid;

        public Maze(int width, int length)
        {
            mazeGrid = new MazeElement[width, length];
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Maze Grid", mazeGrid);
        }

        public Maze(SerializationInfo info, StreamingContext context)
        {
            mazeGrid = (MazeElement[,])info.GetValue("Maze Grid", typeof(MazeElement[,]));
        }

        public Maze()
        {
            #region TestCode_TO-DELETE
            //mazeGrid = new MazeElement[10, 15];
            //for (int i = 0; i < mazeGrid.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mazeGrid.GetLength(1); j++)
            //    {
            //        mazeGrid[i, j] = new MazeElement(i, j);
            //    }
            //}
            #endregion
        }
    }
}
