using System;
using System.Collections.Generic;

namespace Planner
{
    class Building
    {
        private string _designer = "Clifton Matuszewski";

        public string getDesigner()
        {
            return _designer;
        }
        private DateTime _dateConstructed { get; set; }

        public DateTime getDate()
        {
            return _dateConstructed;
        }

        private string _address { get; set; }

        public string getAddress()
        {
            return _address;
        }

        private string _owner { get; set; }

        public string getOwner()
        {
            return _owner;
        }

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (Stories * 3);
            }
        }

        public Building(string address){
            _address = address;
        }

        public void CreationTime(){
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name){
            _owner = name;
        }

        // public void DisplayBuilding(){
        //     Console.WriteLine(_address);
        //     Console.WriteLine("-----");
        //     Console.WriteLine($"Designed by {_designer}");
        //     Console.WriteLine($"Constructed on {_dateConstructed}");
        //     Console.WriteLine($"Owned by {_owner}");
        //     Console.WriteLine($"{Volume} cubic meters of space");
        // }


        static void Main(string[] args)
        {
            Building Int500Blv = new Building("500 Interstate Blvd S."){
                Width = 2222.22,
                Depth = 3255.31,
                Stories = 21
            };

            Building EvanBack = new  Building("3002 Evanback Court"){
                Width = 500,
                Depth = 453.99,
                Stories = 2
            };

            Building DreamOn = new Building("2022 Neverland Imagination Way"){
                Width = 500000.34,
                Depth = 345566.12,
                Stories = 99
            };

            Int500Blv.Purchase("John");
            EvanBack.Purchase("Steve Matuszewski");
            DreamOn.Purchase("Clifton Matuszewski");

            Int500Blv.CreationTime();
            EvanBack.CreationTime();
            DreamOn.CreationTime();

            List<Building> Property = new List<Building>(){
                Int500Blv, EvanBack, DreamOn
            };
            
            foreach(Building building in Property){
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

