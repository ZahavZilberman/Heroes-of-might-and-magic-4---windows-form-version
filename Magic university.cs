using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Magic_university
    {
        #region Constructor

        public Magic_university(List<Hero> AllIntrestedHeroes)
        {
            GoldCost = 2000;
            AllMagicSkillsOfferedForHero = new List<Skill>();
            // than you add to it all spell-related skills - over 100 in total

            foreach(Hero hero in AllIntrestedHeroes)
            {
                if(hero.IsCursorFocused)
                {
                    
                }
            }
        }

        #endregion

        #region Propeties

        public List<Skill> AllMagicSkillsOfferedForHero { get; set; }
        public double GoldCost { get; set; }        

        #endregion
    }
}
