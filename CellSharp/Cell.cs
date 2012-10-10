using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellSharp
{
    class Cell
    {
        #region "Properties"

        public int XPos { get; set; }
        public int YPos { get; set; }
        public int NeighborCount { get; set; }

        #endregion

        #region "Constructors"

        public Cell(int xPos, int yPos)
        {
            NeighborCount = 0;
            XPos = xPos;
            YPos = yPos;
        }

        public Cell(Cell existingCell)
        {
            XPos = existingCell.XPos;
            YPos = existingCell.YPos;
            NeighborCount = existingCell.NeighborCount;
        }

        #endregion

        #region "Public"

        public bool CheckForDuplicates(List<Cell> cells)
        {
            foreach (Cell cell in cells)
            {
                if (cell.XPos == XPos && cell.YPos == YPos)
                    return false;
            }

            return true;
        }

        public int CheckNumberDuplicates(List<Cell> cells)
        {
            int count = 0;
            foreach (Cell cell in cells)
            {
                if (cell.XPos == XPos && cell.YPos == YPos)
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
            if (XPos == 120 || XPos == -20 || YPos == 120 || YPos == -20)
                return true;

            return false;
        }

        private void CheckLeftRight(Cell cell)
        {
            if(cell.YPos == YPos)
            {
                if (cell.XPos == XPos - 1 || cell.XPos == XPos + 1)
                    NeighborCount++;
            }
        }

        private void CheckTop(Cell cell)
        {
            if (cell.YPos == YPos - 1)
            {
                if (cell.XPos == XPos || cell.XPos == XPos + 1 || cell.XPos == XPos - 1)
                    NeighborCount++;
            }
        }

        private void CheckBottom(Cell cell)
        {
            if (cell.YPos == YPos + 1)
            {
                if (cell.XPos == XPos || cell.XPos == XPos + 1 || cell.XPos == XPos - 1)
                    NeighborCount++;
            }
        }

        #endregion
    }
}
