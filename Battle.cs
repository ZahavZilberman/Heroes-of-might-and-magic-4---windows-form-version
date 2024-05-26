using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Battle
    {
        #region Constructor

        public Battle(List<Army> armiesFighting, string filePathToBattleArea, double surrenderingCost, List<bool> canPlayersRetreat, List<bool> canPlayersSurrender, bool isBattleForConquerCastle, Castle? CastleBeingAttackedParameter = null)
        {
            ArmiesFighting = armiesFighting;
            FilePathToBattleArea = filePathToBattleArea;
            SurrenderingCost = surrenderingCost;
            CanPlayersRetreat = canPlayersRetreat;
            CanPlayersSurrender = canPlayersSurrender;
            IsBattleForConquerCastle = isBattleForConquerCastle;

            if(IsBattleForConquerCastle)
            {
                bool IsThereAWall = false;

                CastleBeingAttacked = CastleBeingAttackedParameter;
                foreach(Building building in CastleBeingAttacked.AlreadyBuilt)
                {
                    if(building.Name == "Castle")
                    {
                        DoesCastleHaveTheStages = true;
                        GateHP = 150;
                        IsGateDestroyed = false;
                        IsThereAWall = true;
                    }
                    if (building.Name == "Citedal")
                    {
                        DoesCastleHaveTheStages = false;
                        GateHP = 100;
                        IsGateDestroyed = false;
                        IsThereAWall = true;
                    }
                    if (building.Name == "Fort")
                    {
                        DoesCastleHaveTheStages = false;
                        GateHP = 50;
                        IsGateDestroyed = false;
                        IsThereAWall = true;
                    }
                }
                AreThereAreWalls = IsThereAWall;
            }
        }

        #endregion

        #region Propeties

        public List<Army> ArmiesFighting { get; set; }
        public Army Winner { get; set; }
        public Army Loser { get; set; }
        public string FilePathToBattleArea { get; set; } // is generated based on the tile position - in another fucntion
        public double SurrenderingCost { get; set; } // will be calculated when neccesary
        public List<bool> CanPlayersRetreat { get; set; }
        public List<bool> CanPlayersSurrender { get; set; }    
        public bool IsBattleForConquerCastle { get; set; }
        public Castle? CastleBeingAttacked { get; set; }
        public bool? DoesCastleHaveTheStages { get; set; } // stages are those things that double the ATK and DEF of the guy standing on them and give him no range penalities
        public double? GateHP { get; set; }
        public bool? IsGateDestroyed { get; set; }
        public bool AreThereAreWalls { get; set; }

        #endregion
    }
}
