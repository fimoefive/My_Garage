using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Garage.Vehicles
{
    class Aircraft : Vehicle
    {
        // Public Properties
        public short Fuel { get; set; }
        public string Color { get; set; }
        public int Occupancy { get; set; }


        // Method Refueling
        public void Refueling()
        {
            if (Fuel <= 33)
            {
                Console.WriteLine("Prepair for landing to refuel.");
            }
        }

        // Method Flying
        public void Flying()
        {
            Console.WriteLine("We are airborn, buckel up!");
        }

        // Method Landing
        public void Landing()
        {
            Console.WriteLine("Tower we are decending and approching the runway.");
        }


    }
}
