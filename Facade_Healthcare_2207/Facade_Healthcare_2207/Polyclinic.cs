using System;

namespace Facade_Healthcare_2207
{
    internal class Polyclinic
    {
        private string name;
        private string location;

        public Polyclinic(string name, string location)
        {
            this.name = name;
            this.location = location;
        }

        public void RegisterVisit(Patient patient)
        {
            Console.WriteLine($"{patient.GetName()} {name} polikliniğinde {location} ziyaretini gerçekleştirdi.");
        }
    }
}