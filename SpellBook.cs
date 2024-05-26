using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class SpellBook
    {
        #region Constructors

        public SpellBook(bool IsHeroAOwner, Hero? HeroOwner = null, Creature? CreatureOwner = null)
        {
            AllAdventureSpells = new List<Spell>();
            AllBattleSpells = new List<Spell>();

            if(IsHeroAOwner)
            {
                HeroSpellBookOwner = HeroOwner;
                SpellBookCreatureOwner = null;

                //foreach(Spell spell in HeroOwner.)
            }
            else
            {
                SpellBookCreatureOwner = CreatureOwner;
                HeroSpellBookOwner = null;
            }
        }

        #endregion

        #region Properties

        public List<Spell> AllAdventureSpells { get; set; }
        public List<Spell> AllBattleSpells { get; set; }
        public Hero? HeroSpellBookOwner { get; set; }
        public Creature? SpellBookCreatureOwner { get; set; }

        #endregion
    }
}
