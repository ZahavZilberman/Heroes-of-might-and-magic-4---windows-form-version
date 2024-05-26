using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Dwelling
    {
        #region Constructor

        public Dwelling(Player? thePlayerItBelongsTo, Creature theCreatureItGenerates, double xTilePosition, double yTilePosition)
        {
            ThePlayerItBelongsTo = thePlayerItBelongsTo;
            TheCreatureItGenerates = theCreatureItGenerates;
            XTilePosition = xTilePosition;
            YTilePosition = yTilePosition;
        }

        #endregion

        #region Properties

        public Player? ThePlayerItBelongsTo { get; set; }
        public Creature TheCreatureItGenerates { get; set; }
        public double XTilePosition { get; set; }
        public double YTilePosition { get; set;}        

        #endregion
    }
}
