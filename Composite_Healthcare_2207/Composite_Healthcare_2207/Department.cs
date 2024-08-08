using System.Collections.Generic;
using System.Xml.Linq;
using System;

namespace Composite_Healthcare_2207
{
    internal class Department : HealthcareEntity, IHealthcareUnit
    {
        protected List<IHealthcareProfessional> professionals;

        public Department(string name, string color) : base(name, color)
        {
            professionals = new List<IHealthcareProfessional>();
        }

        public override void PerformDuties()
        {
            Console.WriteLine($"\nDepartman {name} görevlerini yerine getiriyor.");

            foreach (var professional in professionals)
            {
                professional.PerformDuties();
            }
        }

        public override void TakeBreak()
        {
            Console.WriteLine($"\nDepartman {name} ara veriyor.");
            foreach (var professional in professionals)
                professional.TakeBreak();
        }

        public override void AttendTraining()
        {
            Console.WriteLine($"\nDepartman {name}  eğitime katılıyor.");

            foreach (var professional in professionals)
                professional.AttendTraining();
        }

        public void AddProfessional(IHealthcareProfessional professional)
        {
            professionals.Add(professional);
        }

        public void RemoveProfessional(IHealthcareProfessional professional)

        { 
            professionals.Remove(professional);
        }

        public List<IHealthcareProfessional> GetProfessionals()
        {
            return professionals;
        }

        public void ListProfessionals()
        {
            Console.WriteLine("\nSağlık personelleri:");

            foreach (var professional in professionals)
            {
                Console.WriteLine(((IHealthcareProfessional)professional).ToString());
            }
        }

        public void AddProfessionals(List<IHealthcareProfessional> professionals)
        {
            this.professionals.Clear();
            this.professionals.AddRange(professionals);
        }
    }
}