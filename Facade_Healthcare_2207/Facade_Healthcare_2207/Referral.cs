using System;

namespace Facade_Healthcare_2207
{
    internal class Referral
    {
        private Patient patient;
        private string department;

        public Referral(Patient patient, string department)
        {
            this.patient = patient;
            this.department = department;
        }

        public void IssueReferral()
        {
            Console.WriteLine($"{patient.GetName()} {patient.GetSurname()} için {department} bölümüne sevk yapıldı.");
        }
    }
}