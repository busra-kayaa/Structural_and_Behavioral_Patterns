using System;

namespace Strategy_Healthcare_2207
{
    internal class EmergencyAppointmentStrategy : IAppointmentStrategy
    {
        public void Process(Appointment appointment)
        {
            Console.WriteLine("" + appointment.Patient.Name + " için " + appointment.Doctor.Name + " ile acil randevu işleniyor.");
        }
    }
}