using System;

namespace Command_Database_2207
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
            return $"Randevu [DoktorID={Doctor}, Tarih={Date}]";
        }
    }

}