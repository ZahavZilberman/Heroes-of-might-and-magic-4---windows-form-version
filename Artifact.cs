using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Artifact
    {
        #region Constructor

        public Artifact(string name, string description, string type, string whereItCanBePut, bool isOnHero, bool isOnMap, bool isOnGuardian, bool isInHeroReserves, double aTKPointsDifference, double dEFPointsDifference, double hPDifferenec, double rangedAttackDiffernce, double spellPointDifference, bool partOfFusion, Hero isOnThisHero, Creature isOnThisCreature, double xTilePosition, double yTilePosition)
        {
            Name = name;
            Description = description;
            Type = type;
            WhereItCanBePut = whereItCanBePut;
            IsOnHero = isOnHero;
            IsOnMap = isOnMap;
            IsOnGuardian = isOnGuardian;
            IsInHeroReserves = isInHeroReserves;
            ATKPointsDifference = aTKPointsDifference;
            DEFPointsDifference = dEFPointsDifference;
            HPDifferenec = hPDifferenec;
            RangedAttackDiffernce = rangedAttackDiffernce;
            SpellPointDifference = spellPointDifference;
            PartOfFusion = partOfFusion;
            IsOnThisHero = isOnThisHero;
            IsOnThisCreature = isOnThisCreature;
            XTilePosition = xTilePosition;
            YTilePosition = yTilePosition;
        }

        #endregion

        #region Properties

        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string WhereItCanBePut { get; set; }
        public bool IsOnHero { get; set; }
        public bool IsOnMap { get; set; }
        public bool IsOnGuardian { get; set; }
        public bool IsInHeroReserves { get; set; }
        public double ATKPointsDifference { get; set; }
        public double DEFPointsDifference { get; set; }
        public double HPDifferenec { get; set; }
        public double RangedAttackDiffernce { get; set; }
        public double SpellPointDifference { get; set; }
        //public Spell SpellProvided
        public bool PartOfFusion { get; set; }
        public Hero IsOnThisHero { get; set; }
        public Creature IsOnThisCreature { get; set; }
        public double XTilePosition { get; set; }
        public double YTilePosition { get; set; }

        #endregion
    }
}
