using System;

namespace Composite_Healthcare_2207
{
    internal class Doctor : HealthcareEntity
    {
        public Doctor(string name, string specialization) : base(name, specialization) { }

        public override void PerformDuties()
        {
            Console.WriteLine($"Doktor {name}, {specialization}, alanında görevlerini yerine getiriyor.");
        }

        public override void TakeBreak()
        {
            Console.WriteLine($"Doktor {name}, {specialization}, alanında ara veriyor.");
        }

        public override void AttendTraining()
        {
            Console.WriteLine($"Doktor {name}, {specialization}, alanında eğitime katılıyor.");
        }
    }
}