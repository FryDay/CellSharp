using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellSharp
{
    class Main
    {
        #region "Properties"

        private Population LivingCells { get; set; }
        private Ruleset Rules;
        private int CurrentIteration = 0;

        #endregion

        #region "Constructors"

        public Main(int birthMin, int birthMax, int survivalMin, int survivalMax)
        {
            Rules = new Ruleset(birthMin, birthMax, survivalMin, survivalMax);

        }

        #endregion

        #region "Public"

        public void Iterate()
        {

        }

        #endregion
    }
}
