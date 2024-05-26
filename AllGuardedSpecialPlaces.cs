using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class AllGuardedSpecialPlaces
    {
        public AllGuardedSpecialPlaces(List<double> amountOfCreatures, List<Resource> resourceWonByWinning, bool isThereAnyoneInThere)
        {
            TheCreaturesGuradingIt = new List<Creature>();
            amountOfCreatures = new List<double>();
            ResourceWonByWinning = new List<Resource>();

            IsThereAnyoneInThere = isThereAnyoneInThere;
            if(IsThereAnyoneInThere)
            {
                AmountOfCreatures = amountOfCreatures;
                ResourceWonByWinning = resourceWonByWinning;
                
            }
        }

        public double XTilePosition { get; set; }
        public double YTilePosition { get; set; }
        public List<Creature> TheCreaturesGuradingIt { get; set; }
        public List<double> AmountOfCreatures { get; set; }
        public List<Resource> ResourceWonByWinning { get; set; }
        public bool IsThereAnyoneInThere { get; set; }
    }
}
