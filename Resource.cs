using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Resource
    {
        public Resource(double xTilePosition, double yTilePosition, double resourceName, double resourceAmount, bool existsInMap)
        {
            XTilePosition = xTilePosition;
            YTilePosition = yTilePosition;
            ResourceName = resourceName;
            ResourceAmount = resourceAmount;
            ExistsInMap = true;
        }

        public double XTilePosition { get; set; }
        public double YTilePosition { get; set; }
        public double ResourceName { get; set; }
        public double ResourceAmount { get; set; }
        public bool IsFire { get; set; }
        public bool ExistsInMap { get; set; }
    }
}
