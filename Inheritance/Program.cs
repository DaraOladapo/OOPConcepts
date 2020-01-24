using System;

namespace Inheritance
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
            Console.WriteLine($"Now we have our {myCar.Make} {myCar.Model} {myCar.Year} has a companion app of {myCar.CompanionApp}");
            myCar.Start();
            myCar.Accelerate();
            myCar.Reverse();
            myCar.Stop();
            Console.ReadLine();
        }
    }
}
