using System;

namespace Facade_Healthcare_2207
{
    internal class Surgery
    {
        private string name;
        private Doctor doctor;
        private Patient patient;
        private DateTime date;

        public Surgery(string name, Doctor doctor, Patient patient, DateTime date)
        {
            this.name = name;
            this.doctor = doctor;
            this.patient = patient;
            this.date = date;
        }

        public void ScheduleSurgery()
        {
            Console.WriteLine($"{date} tarihinde {patient.GetName()} {patient.GetSurname()} için {name} planlandı. Operasyon Dr. {doctor.GetName()} {doctor.GetSurname()} tarafından gerçekleştirilecektir.");
        }
    }
}