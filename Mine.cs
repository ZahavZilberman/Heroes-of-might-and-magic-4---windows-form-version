using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Mine
    {
        #region Constructor

        public Mine(string mineResource, Player? thePlayerWhoOwnsThisMine = null)
        {
            // WhichPlayerBlaBla = should be nullable
            MineResource = mineResource;

            if (MineResource == "Ore" || MineResource == "Wood")
            {
                HowMuchPerDayItGives = 2;
            }
            else if (MineResource == "Gold")
            {
                HowMuchPerDayItGives = 1000;
            }
            else
            {
                HowMuchPerDayItGives = 1;
            }

            Player? thePlayerWhoOwnsThisMine1 = thePlayerWhoOwnsThisMine;
            ThePlayerWhoOwnsThisMine = thePlayerWhoOwnsThisMine1;
        }

        #endregion

        #region Properties

        public Player? ThePlayerWhoOwnsThisMine{get;set;}
        public string MineResource { get; set; }
        public int HowMuchPerDayItGives { get; set; }
        

        #endregion
    }
}
