using System.Xml.Linq;
using System;

namespace Composite_Healthcare_2207
{
    internal class Surgeon : HealthcareEntity
    {
        public Surgeon(string name, string specialization) : base(name, specialization) { }

        public override void PerformDuties()
        {
            Console.WriteLine($"Cerrah {name}, {specialization}, alanında görevlerini yerine getiriyor.");
        }

        public override void TakeBreak()
        {
            Console.WriteLine($"Cerrah {name}, {specialization}, alanında ara veriyor.");
        }

        public override void AttendTraining()
        {
            Console.WriteLine($"Cerrah {name}, {specialization}, alanında eğitime katılıyor.");
        }
    }
}
