using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile myAutomobile = new Automobile();
            myAutomobile.Make = "Toyota";
            myAutomobile.Model = "Corolla";
            myAutomobile.Year = 2015;
            myAutomobile.EngineType = Engine.Hybrid;
            myAutomobile.TransmissionType = Transmission.Automatic;
            Console.WriteLine($"Now we have our {myAutomobile.Make} {myAutomobile.Model} {myAutomobile.Year}");
            Console.ReadLine();
        }
    }
}
