using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Garage.Vehicles
{
    class Car : Vehicle
    {
        // Public Properties
        public short Fuel { get; set;} 
        public short Battery { get; set; }
        public string Color { get; set; }
        public int Occupancy { get; set; }

        // Refueling Method
        public void Refueling()
        {
            if (Fuel <= 33)
            {
                Console.WriteLine("Stop at the nearest gas station ahead.");
            }
            else if (Battery <= 20)
            {
                Console.WriteLine("Find the nearest Tesla charging station");
            }

        }

        // Driving Method
        public void Driving()
        {
            if (Occupancy == 1)
            {
                Console.WriteLine("Go ten miles above the speed limit.");
            }
            else if (Occupancy >= 2)
            {
                Console.WriteLine("Drive safe and go the speed limit.");
            }

        }

        //  Braking Method
        public void Braking()
        {
            Console.WriteLine("Pump the breaks.");
        }


    }
}
