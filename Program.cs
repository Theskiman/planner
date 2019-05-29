using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {


        static void Main(string[] args)
        {
            Building Int500Blv = new Building("500 Interstate Blvd S.")
            {
                Width = 2222.22,
                Depth = 3255.31,
                Stories = 21
            };

            Building EvanBack = new Building("3002 Evanback Court")
            {
                Width = 500,
                Depth = 453.99,
                Stories = 2
            };

            Building DreamOn = new Building("2022 Neverland Imagination Way")
            {
                Width = 500000.34,
                Depth = 345566.12,
                Stories = 99
            };
            City MistVillage = new City()
            {
                _villageName = "Mist Village",
                _ruler = "Lord Mist",
                _villageYear = 3123
            };

            Int500Blv.Purchase("John");
            EvanBack.Purchase("Steve Matuszewski");
            DreamOn.Purchase("Clifton Matuszewski");

            Int500Blv.CreationTime();
            EvanBack.CreationTime();
            DreamOn.CreationTime();

            MistVillage.addBuilding(DreamOn);
            MistVillage.addBuilding(Int500Blv);
            MistVillage.addBuilding(EvanBack);

            foreach (Building building in MistVillage.villageBuildings)
            {
                Console.WriteLine();
                Console.WriteLine(MistVillage._villageName);
                Console.WriteLine(building.getAddress());
                Console.WriteLine("-----");
                Console.WriteLine($"Designed by {building.getDesigner()}");
                Console.WriteLine($"Constructed on {building.getDate()}");
                Console.WriteLine($"Owned by {building.getOwner()}");
                Console.WriteLine($"{building.Volume} cubic meters of space");
                Console.WriteLine(" ");
            }

            Building Quickening = new Building("MistVillage")
            {
                Width = 4000,
                Depth = 50000,
                Stories = 30
            };

            City ActualMist = new City()
            {
                _villageName = "Real Mist Village",
                _ruler = "Lord Richter",
                _villageYear = 3000
            };
            Quickening.Purchase("Lord Richter");
            Quickening.CreationTime();

            ActualMist.addBuilding(Quickening);

            foreach(Building building in ActualMist.villageBuildings){
                Console.WriteLine();
                Console.WriteLine(ActualMist._villageName);
                Console.WriteLine(building.getAddress());
                Console.WriteLine("-----");
                Console.WriteLine($"Designed by {building.getDesigner()}");
                Console.WriteLine($"Constructed on {building.getDate()}");
                Console.WriteLine($"Owned by {building.getOwner()}");
                Console.WriteLine($"{building.Volume} cubic meters of space");
                Console.WriteLine(" ");
            }
        }
    }
}

