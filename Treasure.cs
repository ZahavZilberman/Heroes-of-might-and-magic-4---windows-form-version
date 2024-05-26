using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace HOMM4
{
    public class Treasure
    {
        #region Constructor

        public Treasure()
        {
            Random randomNumberForGoldAndEXP = new Random();
            int ChoosenRandom = randomNumberForGoldAndEXP.Next(1, 4);

            if(ChoosenRandom == 1)
            {
                Gold = 1000;
                EXP = 500;
            }
            if (ChoosenRandom == 2)
            {
                Gold = 1500;
                EXP = 1000;
            }
            if (ChoosenRandom == 3)
            {
                Gold = 2000;
                EXP = 1500;
            }
            if (ChoosenRandom == 4)
            {
                throw new Exception("Never heard of a case where the random value can reach the defined maximum value..");
            }

            // dunno for now if to get the x/y tile position from the class who creates the new instance.
        }

        #endregion

        #region Properties

        public double Gold { get; set; }
        public double EXP { get; set; }
        public double XTilePosition { get; set; }
        public double YTilePosition { get; set; }

        #endregion
    }
}
