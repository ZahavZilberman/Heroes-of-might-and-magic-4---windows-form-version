using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Map
    {
        #region Constructor

        public Map(string name, string description, string mapDiffculty, string playerDiffculty, List<string> aviliableFlags, List<string> possibleHumanFlags, List<string> possibleAIFlags, string mapSize, double xAndYTileAmount, string victoryCondition, string loseCondition, string generalMapInfoFilePath, string actualMapTilesFilePath, List<Player> mapPlayers, List<Mine> mines, List<Castle> castles, List<Treasure> treasures)
        {
            Name = name;
            Description = description;
            MapDiffculty = mapDiffculty;
            PlayerDiffculty = playerDiffculty;
            AviliableFlags = aviliableFlags;
            PossibleHumanFlags = possibleHumanFlags;
            PossibleAIFlags = possibleAIFlags;
            MapSize = mapSize;
            XAndYTileAmount = xAndYTileAmount;
            VictoryCondition = victoryCondition;
            LoseCondition = loseCondition;
            GeneralMapInfoFilePath = generalMapInfoFilePath;
            ActualMapTilesFilePath = actualMapTilesFilePath;
            MapPlayers = mapPlayers;
            Mines = mines;
            Castles = castles;
            Treasures = treasures;

            day = 1;
            week = 1;
            year = 1;

            // alternativly, we can at the constructor open the 2 text files containing all map data, and update all the above properties according to their content
        }

        public static DateTime AnyDataUpdate(double month, double week, double day)
        {
            string countYearZeros = "000";
            string countMonthZeros = "00";
            string countWeekZeros = "0";

            for (int i = 1; i <= week; i = i * 10)
            {
                countYearZeros.Remove((countYearZeros.Count() - 1));
                if (i <= month)
                {
                    countMonthZeros.Remove((countMonthZeros.Count() - 1));
                }
            }

            countYearZeros = NumOfZerosForDateTime(countYearZeros);
            countMonthZeros = NumOfZerosForDateTime(countMonthZeros);

            return DateTime.Parse($"{day}/{countMonthZeros}{month}/{countYearZeros}{week}");

        }

        public static string NumOfZerosForDateTime(string zeros)
        {
            if (zeros == "0")
            {
                return "";
            }
            return zeros;
        }

        #endregion

        #region Properties

        public string Name { get; set; }
        public string Description { get; set; }
        public string MapDiffculty { get; set; }
        public string PlayerDiffculty { get; set; }
        public List<string> AviliableFlags { get; set; }
        public List<string> PossibleHumanFlags { get; set; }
        public List<string> PossibleAIFlags { get; set; }
        public string MapSize { get; set; }
        public double XAndYTileAmount { get; set; }
        public string VictoryCondition { get; set; }
        public string LoseCondition { get; set; }
        public string GeneralMapInfoFilePath { get; set; }
        // public List<Tile> AllTiles{get;set;}
        public string ActualMapTilesFilePath { get; set; }
        public List<Player> MapPlayers { get; set; }
        public List<Mine> Mines { get; set; }
        public List<Castle> Castles { get; set; } // just in case no player has any castles
        public List<Treasure> Treasures { get; set; }
        public List<Resource> Resources { get; set; }
        public double NumberOfTeams { get; set; }
        //public DateTime date { get; set; }
        public double day { get; set; }
        public double week { get; set; }
        public double year { get; set; }

        #endregion
    }
}
