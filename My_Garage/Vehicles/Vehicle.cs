using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Vehicles namespace
namespace My_Garage.Vehicles
{
    // Abstract Class for Vehicle base
    abstract class Vehicle
    {
        // Public Properties
        public short Fuel { get; set; }
        public short Battery { get; set; }
        public string Color { get; set; }
        public int Occupancy { get; set; }

        // Invoked Abstract Method
        public abstract void Refueling();

    }
}
