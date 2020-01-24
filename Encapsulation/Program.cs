using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile myAutomobile = new Automobile();
            myAutomobile.Make = "Toyota";
            myAutomobile.Model = "Prius";
            myAutomobile.Year = 2015;
            myAutomobile.EngineType = Engine.Hybrid;
            myAutomobile.TransmissionType = Transmission.Automatic;
            Console.WriteLine($"Now we have our {myAutomobile.Make} {myAutomobile.Model} {myAutomobile.Year}");
            myAutomobile.Start();
            myAutomobile.Accelerate();
            myAutomobile.Reverse();
            myAutomobile.Stop();
            Console.ReadLine();
        }
    }
}
