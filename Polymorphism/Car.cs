using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Car : Automobile
    {
        public string CompanionApp { get; set; }
        public override void Stop()
        {
            Console.WriteLine($"{this.Make} {this.Model} {this.Year} is stopping.");
        }
    }
}
