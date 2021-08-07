using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Garage.Vehicles
{
    class Watercraft : Vehicle
    {
        // Public Properties
        public short Fuel { get; set; }
        public string Color { get; set; }
        public int Occupancy { get; set; }
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
