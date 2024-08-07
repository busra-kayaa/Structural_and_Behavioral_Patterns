using System;

namespace Command_Healthcare_2207
{
    internal class Appointment
    {
        public Doctor Doctor { get; private set; }
        public DateTime Date { get; private set; }

        public Appointment(Doctor doctor, DateTime date)
        {
            Doctor = doctor;
            Date = date;
        }

        public override string ToString()
        {
            return $"Randevu [Doktor={Doctor}, Tarih={Date}]";
        }
    }
}