using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellSharp
{
    class Cell
    {
        #region "Properties"

        public Point Location { get; set; }
        public int NeighborCount { get; set; }

        #endregion

        #region "Constructors"

        public Cell(int x, int y)
        {
            NeighborCount = 0;
            Location = new Point(x, y);
        }

        public Cell(Cell existingCell)
        {
            Location = existingCell.Location;
            NeighborCount = existingCell.NeighborCount;
        }

        #endregion

        #region "Public"

        public bool CheckForDuplicates(List<Cell> cells)
        {
            foreach (Cell cell in cells)
            {
                if (cell.Location.Equals(Location))
                    return false;
            }

            return true;
        }

        public int CheckNumberDuplicates(List<Cell> cells)
        {
            int count = 0;
            foreach (Cell cell in cells)
            {
                if (cell.Location.Equals(Location))
                    count += 1;
            }

            return count;
        }

        public void CountNeighbors(List<Cell> cellList)
        {
            NeighborCount = 0;
            if (Edge())
            {
                cellList.Remove(this);
            }
            else
            {
                foreach (Cell cell in cellList)
                {
                    CheckLeftRight(cell);
                    CheckBottom(cell);
                    CheckTop(cell);
                }
            }

        }

        #endregion

        #region "Private"

        private bool Edge()
        {
            if (Location.X == 120 || Location.X == -20 || Location.Y == 120 || Location.Y == -20)
                return true;

            return false;
        }

        private void CheckLeftRight(Cell cell)
        {
            if(cell.Location.Y == Location.Y)
            {
                if (cell.Location.X == Location.X - 1 || cell.Location.X == Location.X + 1)
                    NeighborCount++;
            }
        }

        private void CheckTop(Cell cell)
        {
            if (cell.Location.Y == Location.Y - 1)
            {
                if (cell.Location.X == Location.X || cell.Location.X == Location.X + 1 || cell.Location.X == Location.X - 1)
                    NeighborCount++;
            }
        }

        private void CheckBottom(Cell cell)
        {
            if (cell.Location.Y == Location.Y + 1)
            {
                if (cell.Location.X == Location.X || cell.Location.X == Location.X + 1 || cell.Location.X == Location.X - 1)
                    NeighborCount++;
            }
        }

        #endregion
    }
}
