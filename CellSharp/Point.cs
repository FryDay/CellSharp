using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellSharp
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Point p)
        {
            if (this.X == p.X && this.Y == p.Y)
                return true;
            else
                return false;
        }
    }
}
