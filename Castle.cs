using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMM4
{
    public class Castle
    {
        #region Constructor

        public Castle(string castleName, List<string> EnabledBuildingsParameter, List<string> DisabledBuildingsParameter, List<string> BuildAlreadyBuildingsParameter, Player? Owner = null)
        {
            OwnerPlayer = string.Empty;
            HeroGovernore = string.Empty;
            XTilePosition = 0;
            YTilePosition = 0;
            IsCreatureDwellingAviliable = new List<bool>();
            DailyIncome = 0; // usually 500 by default
            AllBuildings = new List<Building>();
            EnabledBulidings = new List<Building>();
            DisabledBuildings = new List<Building>();
            AlreadyBuilt = new List<Building>();
            
            if(DoYouHaveAOwner)
            {
                CastleOwner = Owner; // else - remain null
            }
            
            CastleName = castleName;

            #region Creating all building objects

            Building TownHall = new Building();
            TownHall.woodCost = 10;
            TownHall.OreCost = 10;
            TownHall.GoldCost = 2500;
            TownHall.Type = "GoldIncome";
            TownHall.MoneyProduce = 750;
            /*
            if(DisabledBuildingsParameter.Contains("TownHall"))
            {
                TownHall.IsDisabled = true;
                AllBuildings.Add(TownHall);
                DisabledBuildings.Add(TownHall);
            }
            if(EnabledBuildingsParameter.Contains("TownHall"))
            {
                TownHall.IsEnabled = true;
                AllBuildings.Add(TownHall);
                EnabledBulidings.Add(TownHall);
            }
            if (BuildAlreadyBuildingsParameter.Contains("TownHall"))
            {
                TownHall.IsAlreadyBuilt = true;
                AllBuildings.Add(TownHall);
                AlreadyBuilt.Add(TownHall);
            }
            */
            IsBuildingDisabledEnabledOrBuildInAdvance(TownHall, EnabledBuildingsParameter, DisabledBuildingsParameter, BuildAlreadyBuildingsParameter);

            /*
            foreach(string DisableBulilding in  DisabledBuildingsParameter)
            {
                if(DisableBulilding == "TownHall")
                {
                    TownHall.IsDisabled = true;
                }
            }
            */            

            Building CityHall = new Building();
            CityHall.woodCost = 10;
            CityHall.OreCost = 10;
            CityHall.GoldCost = 2500;
            CityHall.GemCost = 5;
            CityHall.CrystalCost = 5;
            CityHall.Type = "GoldIncome";
            CityHall.MoneyProduce = 1000;

            IsBuildingDisabledEnabledOrBuildInAdvance(CityHall, EnabledBuildingsParameter, DisabledBuildingsParameter, BuildAlreadyBuildingsParameter);
            /*
            if (DisabledBuildingsParameter.Contains("CityHall"))
            {
                CityHall.IsDisabled = true;
                AllBuildings.Add(CityHall);
                DisabledBuildings.Add(CityHall);
            }
            if (EnabledBuildingsParameter.Contains("CityHall"))
            {
                CityHall.IsEnabled = true;
                AllBuildings.Add(CityHall);
                EnabledBulidings.Add(CityHall);
            }
            if (BuildAlreadyBuildingsParameter.Contains("CityHall"))
            {
                CityHall.IsAlreadyBuilt = true;
                AllBuildings.Add(CityHall);
                AlreadyBuilt.Add(CityHall);
            }
            */
            Building Fort = new Building();
            Fort.woodCost = 20;
            Fort.OreCost = 20;
            Fort.GoldCost = 5000;
            Fort.Type = "Walls";

            IsBuildingDisabledEnabledOrBuildInAdvance(Fort, EnabledBuildingsParameter, DisabledBuildingsParameter, BuildAlreadyBuildingsParameter);


            Building Citedal = new Building();
            Citedal.woodCost = 10;
            Citedal.OreCost = 10;
            Citedal.GoldCost = 7500;
            Citedal.Type = "Walls";

            IsBuildingDisabledEnabledOrBuildInAdvance(Citedal, EnabledBuildingsParameter, DisabledBuildingsParameter, BuildAlreadyBuildingsParameter);


            Building Castle = new Building();
            Castle.woodCost = 10;
            Castle.OreCost = 10;
            Castle.GoldCost = 7500;
            Castle.Type = "Walls";

            IsBuildingDisabledEnabledOrBuildInAdvance(Castle, EnabledBuildingsParameter, DisabledBuildingsParameter, BuildAlreadyBuildingsParameter);

            Building Caravan = new Building();
            Caravan.woodCost = 10;
            Caravan.OreCost = 10;
            Caravan.GoldCost = 4000;
            Caravan.Type = "Caravan";

            IsBuildingDisabledEnabledOrBuildInAdvance(Caravan, EnabledBuildingsParameter, DisabledBuildingsParameter, BuildAlreadyBuildingsParameter);

            if(castleName == "Stronghold") // because only that town has this building
            {
                Building BreedingPeds = new Building();
                BreedingPeds.woodCost = 10;
                BreedingPeds.OreCost = 30;
                BreedingPeds.GoldCost = 15000;
                BreedingPeds.Type = "IncreaseGrowth";

                IsBuildingDisabledEnabledOrBuildInAdvance(BreedingPeds, EnabledBuildingsParameter, DisabledBuildingsParameter, BuildAlreadyBuildingsParameter);
            }

            // just some examples - I'll have to find time to add all others, as there are a lot

            #endregion
        }

        #endregion

        #region Functions

        public void IsBuildingDisabledEnabledOrBuildInAdvance(Building building, List<string> AllEnabledBuildings, List<string> AllDisabledBuildings, List<string> AllAlreadyBuiltBuildings)
        {
            if (AllDisabledBuildings.Contains($@"{building.Name}"))
            {
                building.IsDisabled = true;
                AllBuildings.Add(building);
                DisabledBuildings.Add(building);
            }
            if (AllEnabledBuildings.Contains("TownHall"))
            {
                building.IsEnabled = true;
                AllBuildings.Add(building);
                EnabledBulidings.Add(building);
            }
            if (AllAlreadyBuiltBuildings.Contains("TownHall"))
            {
                building.IsAlreadyBuilt = true;
                AllBuildings.Add(building);
                AlreadyBuilt.Add(building);
            }
        }

        #endregion

        #region Properties

        public List<Building> AllBuildings { get; set; }
        public string CastleName { get; set; }
        public List<Building> EnabledBulidings{get;set;}
        public List<Building> DisabledBuildings{get;set;}
        public List<Building> AlreadyBuilt{get;set;}
        public string OwnerPlayer { get; set; }
        public string HeroGovernore { get; set; }
        public double XTilePosition { get; set; }
        public double YTilePosition { get; set; }
        public bool DoYouHaveAOwner { get; set; }
        public List<bool> IsCreatureDwellingAviliable { get; set; }
        public double DailyIncome { get; set; }
        public Player? CastleOwner { get; set; }


        #endregion
    }
}
