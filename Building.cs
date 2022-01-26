using System;

namespace urbanPlanner
{
   public class Building
    {

         public Building(string addressParam)
        {
            _address = addressParam;
        }
        private string _designer = "Marky Mark and the Funky bunch";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get => Width * Depth * (3 * Stories); // read-only
        }

       

        public void Construct()
        {
            _dateConstructed = DateTime.Now;

        }

        public void Purchase(string owner)
        {
            _owner = owner;
        }

       
        public void getInfo()
        {
        Console.WriteLine(_address);
        Console.WriteLine("----------------------");
        Console.WriteLine($"Designed by {_designer}");
        Console.WriteLine($"Constructed on {_dateConstructed}");
        Console.WriteLine($"Owned by {_owner}");
        Console.WriteLine($"{Volume} cubic meters of space");
        Console.WriteLine ("");
        }
        
    }
}


