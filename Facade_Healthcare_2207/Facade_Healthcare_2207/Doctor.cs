using System;

namespace Facade_Healthcare_2207
{
    internal class Doctor
    {
        private string name;
        private string surname;
        private string specialty;

        public Doctor(string name, string surname, string specialty)
        {
            this.name = name;
            this.surname = surname;
            this.specialty = specialty;
        }

        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }

        public string GetSpecialty()
        {
            return specialty;
        }

        public void Diagnose()
        {
            Console.WriteLine($"{name} {surname}, hastayı teşhis ediyor.");
        }
    }
}