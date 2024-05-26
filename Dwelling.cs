using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

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
            // remainingquantity = weekly growth
        }

        #endregion

        public void WhenAHeroApporachesIt(Army army)
        {
            if(army.HeroesInIt.Count > 0)
            {
                // pop up the recruit screen
            }
            else
            {
                // pop up a message saying only hero can recuirt - too complicated for now
                
            }
        }

        #region Properties

        public Player? ThePlayerItBelongsTo { get; set; }
        public Creature TheCreatureItGenerates { get; set; }
        public double RemainingQuantity { get; set; }
        public double XTilePosition { get; set; }
        public double YTilePosition { get; set;}        

        #endregion
    }
}
