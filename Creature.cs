using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Creature
    {
        #region Consturctor

        public Creature(double aTKPoints, double dEFPoints, double hP, double maxHP, double rangedAttack, double rangedDefense, double mapMovement, double battleMovement, double speed, double minimumDamage, double maximumDamage, string pictureFilePath, string whichCastelAreYouFrom, string whichBuildingGeneratesYou, double yourDefaultWeeklyGrowth, double spellPoints, bool IsRanged, bool HasNoMellePenality, bool HasDoubleRangedDefense, double NumberOfShots, List<string> SpecialAbilities, List<Spell>? AdventureSpellsParamter = null, List<Spell>? BattleSpellsParameter = null)
        {
            ATKPoints = aTKPoints;
            DEFPoints = dEFPoints;
            HP = hP;
            MaxHP = maxHP;
            RangedAttack = rangedAttack;
            RangedDefense = rangedDefense;
            MapMovement = mapMovement;
            BattleMovement = battleMovement;
            Speed = speed;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            PictureFilePath = pictureFilePath;
            WhichCastelAreYouFrom = whichCastelAreYouFrom;
            WhichBuildingGeneratesYou = whichBuildingGeneratesYou;
            YourDefaultWeeklyGrowth = yourDefaultWeeklyGrowth;
            SpellPoints = spellPoints;
            IsInOnHisOwn = false;
            IsInHeroArmy = false;
            IsInCastleVisit = false;
            IsInCastleGrassion = false;
            AdventureSpells = new List<Spell>();
            BattleSpells = new List<Spell>();

            if(AdventureSpellsParamter != null)
            {
                AdventureSpells = AdventureSpellsParamter;
            }
            if(BattleSpellsParameter != null)
            {
                BattleSpells = BattleSpellsParameter;
            }

            Shots = 0; // by default - the game code will assume that anyone with 0 shots isn't an archer

            if(HasDoubleRangedDefense)
            {
                RangedDefense = RangedDefense * 2;
            }
            if(IsRanged && !HasNoMellePenality)
            {
                RangedAttack = ATKPoints / 2;
                Shots = NumberOfShots;
            }
            if(IsRanged && HasNoMellePenality)
            {
                RangedAttack = ATKPoints;
                Shots = NumberOfShots;
            }

            #region all abilities

            AllCreaturesAbilities.Add("Stealth");
            AllCreaturesAbilities.Add("Ranged");
            AllCreaturesAbilities.Add("No melle penality");
            AllCreaturesAbilities.Add("Berserk");
            AllCreaturesAbilities.Add("Magic resistence");
            AllCreaturesAbilities.Add("Extra damage to 4 tier");
            AllCreaturesAbilities.Add("No relation");
            AllCreaturesAbilities.Add("Attack twice");
            AllCreaturesAbilities.Add("Double ranged defense");
            AllCreaturesAbilities.Add("Undead");
            AllCreaturesAbilities.Add("Absorb spell points");
            AllCreaturesAbilities.Add("Spellbook");
            AllCreaturesAbilities.Add("Stunning");
            AllCreaturesAbilities.Add("Long range");
            AllCreaturesAbilities.Add("Short range");
            AllCreaturesAbilities.Add("Negate first strike");
            AllCreaturesAbilities.Add("Long weapon");
            AllCreaturesAbilities.Add("Mechanical creature");
            AllCreaturesAbilities.Add("First strike");
            AllCreaturesAbilities.Add("Strike and return");
            AllCreaturesAbilities.Add("Shot twice");
            AllCreaturesAbilities.Add("Unlimited Relation");
            AllCreaturesAbilities.Add("aging");
            AllCreaturesAbilities.Add("double all defense");
            AllCreaturesAbilities.Add("3 headed attack");
            AllCreaturesAbilities.Add("Unlimited shots");
            AllCreaturesAbilities.Add("Stone gaze");
            AllCreaturesAbilities.Add("Teleport"); // devil effect
            AllCreaturesAbilities.Add("Fear");
            AllCreaturesAbilities.Add("Regeneration");
            AllCreaturesAbilities.Add("Ressurction");
            AllCreaturesAbilities.Add("100% Magic immunity");
            AllCreaturesAbilities.Add("Life drain");
            AllCreaturesAbilities.Add("Breath Attack");
            AllCreaturesAbilities.Add("Area Attack");
            AllCreaturesAbilities.Add("Poison");
            AllCreaturesAbilities.Add("Curse"); // the mummia effect
            AllCreaturesAbilities.Add("Hypnotize");
            AllCreaturesAbilities.Add("Summon ice demons");
            AllCreaturesAbilities.Add("Block");
            AllCreaturesAbilities.Add("Terror");
            AllCreaturesAbilities.Add("Fire shield");
            AllCreaturesAbilities.Add("Fire resistence");
            AllCreaturesAbilities.Add("Death ward");
            AllCreaturesAbilities.Add("Life ward");
            AllCreaturesAbilities.Add("Charge");
            AllCreaturesAbilities.Add("Gold produce");
            AllCreaturesAbilities.Add("Devouring");
            AllCreaturesAbilities.Add("Thunder strike");
            AllCreaturesAbilities.Add("Chaos ward");
            AllCreaturesAbilities.Add("Blind");
            AllCreaturesAbilities.Add("Rebirth");
            AllCreaturesAbilities.Add("Magic mirror");
            AllCreaturesAbilities.Add("Multiple attack");
            AllCreaturesAbilities.Add("Fortune");
            AllCreaturesAbilities.Add("Mirth");
            AllCreaturesAbilities.Add("Elemental");
            AllCreaturesAbilities.Add("Water resistence");
            AllCreaturesAbilities.Add("Weakness");
            AllCreaturesAbilities.Add("Binding");
            AllCreaturesAbilities.Add("Freeze");
            AllCreaturesAbilities.Add("Regenration");
            AllCreaturesAbilities.Add("Blind immunity");
            AllCreaturesAbilities.Add("Sea bonus");
            AllCreaturesAbilities.Add("Random harmful spell");
            AllCreaturesAbilities.Add("Arc shaped breath attack");

            #endregion

            ThisCreaturesAbilities = SpecialAbilities;

            foreach(string ability in ThisCreaturesAbilities)
            {
                if(!AllCreaturesAbilities.Contains(ability))
                {
                    throw new Exception("This ability doesn't exist!");
                }
            }
        }

        #endregion

        public void InBattle()
        {
            IsInBattle = true;
            //PositiveSpellsOnIt = new List<Spell>();
            //NegativeSpellsOnIt = new List<Spell>()
        }

        #region Properties

        public double ATKPoints { get; set; }
        public List<Spell> BattleSpells { get; set; }
        public List<Spell> AdventureSpells { get; set; }
        public double DEFPoints { get; set; }
        public double HP { get; set; }
        public double MaxHP { get; set; }
        public double RangedAttack { get; set; }
        public double RangedDefense { get; set; }
        public double MapMovement { get; set; }
        public double BattleMovement { get; set; }
        public double Speed { get; set; }
        public double MinimumDamage { get; set; }
        public double MaximumDamage { get; set; }
        public string PictureFilePath { get; set; } // the picture that appears as there icon in the map and battle field
        public string WhichCastelAreYouFrom { get; set; }
        public string WhichBuildingGeneratesYou { get; set; }
        public double YourDefaultWeeklyGrowth { get; set; }
        // public List<SpecialAbility> Abilities{get;set;}
        public double SpellPoints { get; set; }
        // public List<Spell> Spells{get;set;}
        public double Shots { get; set; }
        public int Cost { get; set; }
        public bool IsInHeroArmy { get; set; }
        public bool IsInOnHisOwn { get; set; }
        public bool IsInCastleVisit { get; set; }
        public bool IsInCastleGrassion { get; set; }
        public bool IsInBattle { get; set; }
        //public List<Spell> PositiveSpellsOnIt{get;set;}
        //public List<Spell> NegativeSpellsOnIt{get;set;}
        public List<string> AllCreaturesAbilities { get; set; }
        public List<string> ThisCreaturesAbilities { get; set; }

        #endregion
    }
}
