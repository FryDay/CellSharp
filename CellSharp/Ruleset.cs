using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellSharp
{
    class Ruleset
    {
        #region "Properties"

        public int BirthMinimum { get; set; }
        public int BirthMaximum { get; set; }
        public int SurvivalMinimum { get; set; }
        public int SurvivalMaximum { get; set; }

        #endregion

        #region "Constructors"

        public Ruleset(int birthMin, int birthMax, int survivalMin, int survivalMax)
        {
            BirthMaximum = birthMax;
            BirthMinimum = birthMin;
            SurvivalMaximum = survivalMax;
            SurvivalMinimum = survivalMin;
        }

        public Ruleset(Ruleset existingRuleset)
        {
            BirthMaximum = existingRuleset.BirthMaximum;
            BirthMinimum = existingRuleset.BirthMinimum;
            SurvivalMaximum = existingRuleset.SurvivalMaximum;
            SurvivalMinimum = existingRuleset.SurvivalMinimum;
        }

        #endregion
    }
}
