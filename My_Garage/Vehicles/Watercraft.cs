using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Vehicles namespace
namespace My_Garage.Vehicles
{
    class Watercraft : Vehicle
    {
        // Object Intializer 
        public Watercraft(string color, int occupancy)
        {
            Fuel = 100;
            Color = color;
            Occupancy = occupancy;
            Fishing = true;

        }

        // Public Property
        public bool Fishing { get; set; }

        // Method Refueling
        public void Refueling()
        {
    if (Fuel <= 33)
            {
                Console.WriteLine("Head back to the dock to refuel.");
            }
        }

        // Method Driving
        public void Driving()
        {
            if (Fishing == true)
            {
                Console.WriteLine("Use the trolly motor.");
            }
            else if (Fishing == false)
            {
                Console.WriteLine("Run the outboard motor.");
            }
        }


    }
}
