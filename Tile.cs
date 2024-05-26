using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Tile
    {
        #region Constructor

        public Tile(string groundType, Castle? castle, Army? hero, Artifact? artifact, Mine? mine, Map itsMap, Treasure? treasure)
        {
            GroundType = groundType;
            Castle = castle;
            Hero = hero;
            Artifact = artifact;
            Mine = mine;
            ItsMap = itsMap;
            Treasure = treasure;
        }

        #endregion

        #region Properties

        public string GroundType { get; set; }
        public Castle? Castle { get; set; }
        public Army? Hero { get; set; }
        public Artifact? Artifact { get; set; }
        public Mine? Mine { get; set; }
        public Map ItsMap { get; set; }
        public Treasure? Treasure { get; set; }
        public double XPosition { get; set; }
        public double YPosition { get; set; }

        #endregion
    }
}
