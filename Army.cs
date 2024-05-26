using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Army // this isn't all player army - each circle is an army in itself
    {
        #region Constructor

        public Army(List<Creature> creaturesInIt, List<Hero> heroesInIt, double xTilePosition, double yTilePosition, double actualMovementRemaining, double movement, bool isInBattle, Player armyOwner, bool isInMap, bool isInCastleVisit, bool isInCastleGrassion)
        {
            CreaturesInIt = creaturesInIt;
            HeroesInIt = heroesInIt;
            XTilePosition = xTilePosition;
            YTilePosition = yTilePosition;
            ActualMovementRemaining = actualMovementRemaining;
            Movement = movement;
            IsInBattle = isInBattle;
            ArmyOwner = armyOwner;
            IsInMap = isInMap;
            IsInCastleVisit = isInCastleVisit;
            IsInCastleGrassion = isInCastleGrassion;
        }

        #endregion

        #region Properties

        public List<Creature> CreaturesInIt { get; set; }
        public List<Hero> HeroesInIt { get; set; }
        public double XTilePosition { get; set; }
        public double YTilePosition { get; set;}
        public double ActualMovementRemaining { get; set; }
        public double Movement { get; set; }
        public bool IsInBattle { get; set; }
        public Player ArmyOwner { get; set; }
        public bool IsInMap { get; set; }
        public bool IsInCastleVisit { get; set; }
        public bool IsInCastleGrassion { get; set; }

        #endregion

    }
}
