using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Garage.Vehicles
{
    abstract class Vehicle
    {
        // Public Properties
        public short Fuel { get; set; }
        public short Battery { get; set; }
        public string Color { get; set; }
        public int Occupancy { get; set; }

        // public abstract void Refueling();
    }
}
