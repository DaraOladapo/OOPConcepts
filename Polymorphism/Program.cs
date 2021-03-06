﻿using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Prius";
            myCar.Year = 2015;
            myCar.EngineType = Engine.Hybrid;
            myCar.TransmissionType = Transmission.Automatic;
            myCar.CompanionApp = "myT";
            Console.WriteLine($"Now we have our {myCar.Make} {myCar.Model} {myCar.Year}");
            myCar.Start();
            myCar.Accelerate();
            myCar.Reverse();
            myCar.Stop();
            Console.ReadLine();
        }
    }
}
