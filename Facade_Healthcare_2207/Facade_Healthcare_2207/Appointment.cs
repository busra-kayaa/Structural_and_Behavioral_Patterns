using System;

namespace Facade_Healthcare_2207
{
    internal class Appointment
    {
        private Doctor doctor;
        private Patient patient;
        private DateTime date;

        public Appointment(Doctor doctor, Patient patient, DateTime date)
        {
            this.doctor = doctor;
            this.patient = patient;
            this.date = date;
        }

        public void Schedule()
        {
            Console.WriteLine($"{date} tarihinde Dr. {doctor.GetName()} {doctor.GetSurname()} ile hasta {patient.GetName()} {patient.GetSurname()} için randevu planlandı.");
        }
    }
}