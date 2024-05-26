using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class ManaVortex
    {
        public ManaVortex(Hero heroWhoWantsToUseIt)
        {
            heroWhoWantsToUseIt.MaxSpellPoints = heroWhoWantsToUseIt.MaxSpellPoints * 2;
            heroWhoWantsToUseIt.RemainingSpellPoints = heroWhoWantsToUseIt.MaxSpellPoints;
        }

        public double XTilePosition { get; set; }
        public double YTilePosition { get; set; }
    }
}
