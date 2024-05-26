using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Marketplace
    {
        public Marketplace(bool IsItOnMap)
        {
            if(IsItOnMap)
            {
                GoldValue = 1 / 500;
                WoodAndOreValue = 1 / 2;
                OtherReasourcesValue = 1 / 4;
            }
            else
            {
                GoldValue = 1 / 750;
                WoodAndOreValue = 1 / 3;
                OtherReasourcesValue = 1 / 6;
            }
        }

        public double GoldValue { get; set; }
        public double WoodAndOreValue { get; set; }
        public double OtherReasourcesValue { get; set; }
    }
}
