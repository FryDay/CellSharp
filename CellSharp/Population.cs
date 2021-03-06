﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellSharp
{
    class Population
    {
        #region "Properties"

        public List<Cell> CellList { get; set; }
        private Ruleset Rules;

        #endregion

        #region "Constructors"

        public Population(Ruleset rules)
        {
            CellList = new List<Cell>();
            Rules = rules;
        }

        public Population(Population existingPopulation)
        {
            CellList = new List<Cell>();
            Rules = existingPopulation.Rules;
            foreach (Cell thisCell in existingPopulation.CellList)
                CellList.Add(new Cell(thisCell));
        }

        #endregion

        #region "Public"

                public Population Run(Ruleset rules)
        {
            Population tempPop = new Population(this);

            for (int index = 0; index < CellList.Count; index++)
            {
                if (!Survive(CellList[index], rules))
                    tempPop.RemoveCell(CellList[index]);
            }

            tempPop.UpdateCellCount();

            Reproduction(tempPop);

            return tempPop;
        }

        public void AddCell(Cell newCell)
        {
            CellList.Add(newCell);
        }

        public void RemoveCell(Cell oldCell)
        {
            for (int index = 0; index < CellList.Count; index++)
            {
                if (oldCell.XPos == CellList[index].XPos && oldCell.YPos == CellList[index].YPos)
                {
                    CellList.Remove(CellList[index]);
                    return;
                }
            }
        }

        public void UpdateCellCount()
        {
            foreach (Cell thisCell in CellList)
                thisCell.CountNeighbors(CellList);
        }

        public void CheckForDuplicates()
        {
            Population tempPop = new Population(this);

            foreach (Cell thisCell in tempPop.CellList)
            {
                if (thisCell.CheckNumberDuplicates(tempPop.CellList) > 1)
                {
                    this.RemoveCell(thisCell);
                    tempPop.Nullify(thisCell);
                }
            }
        }

        #endregion

        #region "Private"

        private bool Survive(Cell checkCell, Ruleset rules)
        {
            if (checkCell.NeighborCount >= rules.SurvivalMinimum && checkCell.NeighborCount <= rules.SurvivalMaximum)
                return true;

            return false;
        }

        private void Reproduction(Population tempPopulation)
        {
            foreach (Cell thisCell in this.CellList)
                tempPopulation.CellList.AddRange(tempPopulation.MakeNewCells(this, thisCell).CellList);
        }

        private Population MakeNewCells(Population currentPop, Cell thisCell)
        {
            Population spawn = new Population(this.Rules);

            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if (CheckReproduction(currentPop, new Cell(thisCell.XPos + x, thisCell.YPos + y)))
                        spawn.AddCell(new Cell(thisCell.XPos + x, thisCell.YPos + y));
                }
            }

            return spawn;
        }

        private bool CheckReproduction(Population currentPop, Cell thisCell)
        {
            thisCell.CountNeighbors(currentPop.CellList);

            if (thisCell.NeighborCount >= Rules.BirthMinimum && thisCell.NeighborCount <= Rules.BirthMaximum)
                return true;

            return false;
        }

        private void Nullify(Cell oldCell)
        {
            oldCell.XPos = -1;
            oldCell.YPos = -1;
        }

        #endregion
    }
}
