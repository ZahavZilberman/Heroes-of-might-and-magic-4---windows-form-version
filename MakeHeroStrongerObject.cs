using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class MakeHeroStrongerObject
    {
        #region Consturctor

        public MakeHeroStrongerObject(bool isATKBonusOrDEF, double xTilePosition, double yTilePosition)
        {
            IsATKBonusOrDEF = isATKBonusOrDEF;
            XTilePosition = xTilePosition;
            YTilePosition = yTilePosition;
        }

        #endregion

        public bool IsATKBonusOrDEF { get; set; }
        public double XTilePosition { get; set; }
        public double YTilePosition { get; set;}

    }
}
