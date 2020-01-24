using System;
namespace Polymorphism
{
    public class Automobile
    {
        private string make;
        private string model;
        private int year;
        private Engine engineType;
        private Transmission transmissionType;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Engine EngineType
        {
            get { return engineType; }
            set { engineType = value; }
        }
        public Transmission TransmissionType
        {
            get { return transmissionType; }
            set { transmissionType = value; }
        }
        public void Start()
        {
            Console.WriteLine("Car engine is starting...");
        }
        public void Accelerate()
        {
            Console.WriteLine("Car is accelerating...");
        }
        public void Reverse()
        {
            Console.WriteLine("Car is reversing...");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Car engine is stopping...");
        }
    }
}
