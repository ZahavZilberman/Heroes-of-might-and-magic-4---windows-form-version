using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Player
    {
        #region Constructor

        public Player(string Flag, List<Army> armies, List<Castle> castles, List<Mine> mines, string PlayerDiffculty)
        {
            FlagColor = Flag;
            Armies = armies;
            Castles = castles;
            Mines= mines;

            if(PlayerDiffculty == "Champion")
            {
                Gold = 0;
                Mercury = 0;
                Gem = 0;
                Crystal = 0;
                Sulfar = 0;
            }
            // will add at other point the default resources for the easier diffculties.
        }

        #endregion

        #region Properties

        public string FlagColor { get; set; }
        public List<Army> Armies { get; set; }
        public List<Castle> Castles { get; set; }
        public List<Mine> Mines { get; set; }
        public double Gold { get; set; }
        //public Map mapToPlayAt{get;set;}
        public double Mercury { get; set; }
        public double Gem { get; set; }
        public double Crystal { get; set; }
        public double Sulfar { get; set; }
        public double TeamNumber { get; set; }

        #endregion
    }
}
