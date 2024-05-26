using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Building
    {
        #region Constructor

        public Building()
        {
            MoneyProduce = 0;
            GoldCost = 0;
            OreCost = 0;
            woodCost = 0;
            GemCost = 0;
            CrystalCost = 0;
            MerCuryCost = 0;
            SulfarCost = 0;
            Name = "";
            Description = "";
            Type = "";
            IsCreatureDwelling = false;
            ItsCastleBelonging = "";
        }

        #endregion

        #region Properties

        public double GoldCost { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsAlreadyBuilt { get; set; }
        public double MoneyProduce { get; set; }
        public double OreCost { get; set; }
        public double woodCost { get; set; }
        public double GemCost { get; set; }
        public double CrystalCost { get; set; }
        public double MerCuryCost { get; set; }
        public double SulfarCost { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool IsCreatureDwelling { get; set; }
        public string ItsCastleBelonging { get; set; }


        #endregion
    }
}
