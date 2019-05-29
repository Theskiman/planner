
using System.Collections.Generic;

namespace Planner{
    class City{
        public string _villageName { get; set;}

        public string _ruler { get; set; }

        

        public int _villageYear { get; set; }


        public List<Building> villageBuildings = new List<Building>();

        public void addBuilding(Building hut){
                villageBuildings.Add(hut);
        }

    }
}