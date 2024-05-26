using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Skill
    {
        #region Consturctor

        public Skill(string skillname, string skilllevel, List<Hero>? ThisSkillsHeroes = null)
        {
            SkillName = skillname;
            SkilLevel = skilllevel;
            HeroesWithThisSkill = ThisSkillsHeroes;

            #region Let's apply this to the combat skill as an example

            if (SkillName == "Combat" && SkilLevel == "Basic")
            {
                foreach(Hero hero in HeroesWithThisSkill)
                {
                    hero.DEFPoints = 15;
                    
                }
            }
            if (SkillName == "Combat" && SkilLevel == "Advanced")
            {
                foreach (Hero hero in HeroesWithThisSkill)
                {
                    hero.DEFPoints = 20;
                }
            }
            if (SkillName == "Combat" && SkilLevel == "Expert")
            {
                foreach (Hero hero in HeroesWithThisSkill)
                {
                    hero.DEFPoints = 30;
                }
            }
            if (SkillName == "Combat" && SkilLevel == "Master")
            {
                foreach (Hero hero in HeroesWithThisSkill)
                {
                    hero.DEFPoints = 40;
                }
            }
            if (SkillName == "Combat" && SkilLevel == "Grandmaster")
            {
                foreach (Hero hero in HeroesWithThisSkill)
                {
                    hero.DEFPoints = 60;
                }
            }

            #endregion
        }

        #endregion

        #region Properties

        public string SkillName { get; set; }
        public string SkilLevel { get; set; } // basic to grandmaster
        public List<Hero>? HeroesWithThisSkill { get; set; }        

        #endregion
    }
}
