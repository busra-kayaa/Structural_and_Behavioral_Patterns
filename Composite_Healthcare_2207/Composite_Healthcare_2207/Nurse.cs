using System;

namespace Composite_Healthcare_2207
{
    internal class Nurse : HealthcareEntity
    {
        public Nurse(string name, string specialization) : base(name, specialization) { }

        public override void PerformDuties()
        {
            Console.WriteLine($"{name}, {specialization} alanında görevlerini yerine getiriyor.");
        }

        public override void TakeBreak()
        {
            Console.WriteLine($"{name},{specialization}  alanında ara veriyor.");
        }

        public override void AttendTraining()
        {
            Console.WriteLine($"{name}, {specialization},  alanında eğitime katılıyor.");
        }
    }
}