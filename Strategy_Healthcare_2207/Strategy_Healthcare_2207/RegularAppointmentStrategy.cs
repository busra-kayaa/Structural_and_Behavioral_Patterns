using System;

namespace Strategy_Healthcare_2207
{
    internal class RegularAppointmentStrategy : IAppointmentStrategy
    {
        public void Process(Appointment appointment)
        {
            Console.WriteLine("" + appointment.Patient.Name + " için " + appointment.Doctor.Name + " ile düzenli randevu işleniyor.");

        }

    }
}