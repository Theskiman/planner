using System;

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
        
    }
}
