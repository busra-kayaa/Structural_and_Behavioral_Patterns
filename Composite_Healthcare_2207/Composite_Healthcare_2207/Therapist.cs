using System.Xml.Linq;
using System;

namespace Composite_Healthcare_2207
{
    internal class Therapist : HealthcareEntity
    {
        public Therapist(string name, string specialization) : base(name, specialization) { }

        public override void PerformDuties()
        {
            Console.WriteLine($"Terapist {name}, {specialization}, alanında görevlerini yerine getiriyor.");
        }

        public override void TakeBreak()
        {
            Console.WriteLine($"Terapist {name}, {specialization}, alanında ara veriyor.");
        }

        public override void AttendTraining()
        {
            Console.WriteLine($"Terapist {name}, {specialization}, alanında eğitime katılıyor.");
        }
    }
}