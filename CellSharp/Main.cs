using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellSharp
{
    class Main
    {
        #region "Properties"

        private Ruleset Rules;
        private int MaxIterations;
        public Population LivingCells { get; set; }
        public int CurrentIteration { get; set; }

        #endregion

        #region "Constructors"

        public Main()
        {
            LivingCells = new Population();
            CurrentIteration = 0;
        }

        public Main(int birthMin, int birthMax, int survivalMin, int survivalMax, int maxIterations, Population pop)
        {
            Rules = new Ruleset(birthMin, birthMax, survivalMin, survivalMax);
            LivingCells = pop;
            CurrentIteration = 0;
        }

        #endregion

        #region "Public"

        //True = keep iterating, False = stop iterating
        public bool Iterate()
        {
            LivingCells = new Population(LivingCells.Run(Rules));
            LivingCells.CheckForDuplicates();
            LivingCells.UpdateCellCount();
            //Update form
            CurrentIteration++;

            if (CurrentIteration >= MaxIterations)
            {
                CurrentIteration = 0;
                return false;
            }
            else
                return true;
        }

        //True = Added Cell, False = Removed Cell
        public bool AddOrRemoveCell(Cell newCell)
        {
            if (newCell.CheckForDuplicates(LivingCells.CellList))
            {
                LivingCells.AddCell(newCell);
                return true;
            }
            else
            {
                LivingCells.RemoveCell(newCell);
                return false;
            }
        }

        #endregion
    }
}
