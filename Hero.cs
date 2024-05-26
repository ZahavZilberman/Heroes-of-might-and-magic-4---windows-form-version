using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Hero
    {
        #region Constructor

        public Hero(string name, int level, string type, string gender, string PathToFilePicture2, string WhereIsHe)/*List<Skill> skills*/
        {
            Name = name;
            Level = 1;
            Type = type;
            Gender = gender;
            PathToFilePicture = PathToFilePicture2;
            if(WhereIsHe == "Grassion")
            {
                IsInGrassion = true;                    
            }
            if(WhereIsHe == "Visit")
            {
                IsInCastleVisit = true;
            }
            if(WhereIsHe == "Map")
            {
                IsOutOfCastle = true;
            }
            HisCreaturesOnHim = new List<Creature>(); //empty by default
            HP = 100;
            HPMax = 100;
            ATKPoints = 10;
            DEFPoints = 10;
            RangedAttack = 0;
            RangedDefense = 10;
            Shots = 0;
            Speed = 7; // is that the default?
            MapMovement = 0; //don't remember the default number
            BattleMovement = 0; //don't remember either
            MagicResistencePrecentage = 0;

            #region Barbarin starting skills - just to give an example

            if(Type == "Barbarian")
            {
                ATKPoints = 15; // basic melle
                DEFPoints = 15; // basic combat
                MagicResistencePrecentage = 30;
                MaxSpellPoints = 10;
                RemainingSpellPoints = 10;

                Skill BasicCombat = new Skill("Combat", "Basic", null);
                Skills.Add(BasicCombat);
                Skill BasicMelle = new Skill("Melle", "Basic", null);
                Skills.Add(BasicMelle);
                Skill BasicMagicResistence = new Skill("MagicResistence", "Basic", null);
                Skills.Add(BasicMagicResistence);
            }
            if(Type == "Archer")
            {
                DEFPoints = 15;
                RangedAttack = 10; // basic archery
                MaxSpellPoints = 10;
                RemainingSpellPoints = 10;

                Skill BasicCombat = new Skill("Combat", "Basic", null);
                Skills.Add(BasicCombat);
                Skill BasicArchery = new Skill("Archery", "Basic", null);
                Skills.Add(BasicArchery);
            }

            // and other examples

            #endregion

            #region Hero speical abilities can include..

            SpecialAbilties.Add("Summon nature creatures");
            SpecialAbilties.Add("Attack 2 yards away");
            SpecialAbilties.Add("No relation");

            #endregion
        }

        #endregion

        #region propeties

        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public string PathToFilePicture { get; set; }
        public double XTileOnMap { get; set; }
        public double YTileOnMap { get; set; }
        public bool IsInGrassion { get; set; }
        public bool IsInCastleVisit { get; set; }
        public bool IsOutOfCastle { get; set; }
        // if he's in castle grassion or visit, his x/y tile position is equal to that of the castle
        public List<Creature> HisCreaturesOnHim { get; set; }
        public double HP { get; set; }
        public double MaxSpellPoints { get; set; }
        // public List<Spell> AdventureMapSpells{get;set;}
        // public List<Spell> BattleSpells{get;set;}
        public double HPMax { get; set; }
        public double RemainingSpellPoints { get; set; }
        public double ATKPoints { get; set; }
        public double DEFPoints { get; set; }
        public double RangedAttack { get; set; }
        public double RangedDefense { get; set; }
        public double Shots { get; set; }
        public double Speed { get; set; }
        public double MapMovement { get; set; } // taking into account terrain pentalities
        public double BattleMovement { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Artifact> Artifacts{get;set;}
        public double MagicResistencePrecentage { get; set; }
        List<string> SpecialAbilties { get; set; }

        #endregion
    }
}
