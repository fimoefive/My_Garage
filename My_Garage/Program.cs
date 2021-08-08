using System;
using My_Garage.Vehicles;
using System.Collections.Generic;

namespace My_Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Garage");

            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            var aircraft = new Aircraft("White", 2);
            aircraft.Flying();
            aircraft.Flying();
            aircraft.Flying();
            aircraft.Landing();
            aircraft.Refueling();


            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            var car = new Car("Black", 3);
            car.Driving();
            car.Driving();
            car.Braking();
            car.Refueling();


            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            var boat = new Watercraft("Green", 4);
            boat.Driving();
            boat.Driving();
            boat.Refueling();



        }
    }
}
