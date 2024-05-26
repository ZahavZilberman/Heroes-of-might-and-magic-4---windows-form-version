using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Spell
    {
        #region Constructor

        public Spell(Castle whichTownItBelongsTo, Player? playerWithThisSpell, string name, string description, string type, bool isPositive, bool isNegative, bool IsBattle)
        {
            WhichTownItBelongsTo = whichTownItBelongsTo;
            PlayerWithThisSpell = playerWithThisSpell;
            Name = name;
            Description = description;
            Type = type;
            IsPositive = isPositive;
            IsNegative = isNegative;
            if(IsBattle)
            {
                IsAdventure = false;
            }
            else
            {
                IsAdventure = true;
            }
        }

        #endregion

        #region Properties

        public Castle WhichTownItBelongsTo { get; set; }
        public Player? PlayerWithThisSpell { get; set; }
        public string Name { get; set; } // based on the name we'll know what it does
        public string Description { get; set; }
        public string Type { get; set; }
        public bool IsPositive { get; set; }
        public bool IsNegative { get; set; }
        public bool IsAdventure { get; set; }


        #endregion
    }
}
