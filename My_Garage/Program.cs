using System;
using My_Garage.Vehicles;
using System.Collections.Concurrent;

namespace My_Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Garage");

            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            var aircraft = new Aircraft("Yellow", 2);
            aircraft.Flying();

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            var car = new Car();
            car.Fuel = 55;
            car.Color = "blue";
            car.Occupancy = 1;

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            var boat = new Watercraft();
            boat.Fuel = 60;
            boat.Occupancy = 2;
            boat.Fishings = true;
            boat.Color = "Green";



        }
    }
}
