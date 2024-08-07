using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Healthcare_2207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //acil
            Patient patient = new Patient("Büşra Kaya",35);
            Doctor doctor = new Doctor("Dr. Hafza Satır", "Kardioloji");
            Appointment appointment = new Appointment(patient, doctor, AppointmentType.Emergency);

            AppointmentContext appointmentContext = new AppointmentContext();
            appointmentContext.ProcessAppointment(appointment);

            //düzenli
            Patient patient1 = new Patient("Basri Koç", 42);
            Doctor doctor1 = new Doctor("Dr. Fatih Yazır", "Üroloji");
            Appointment appointment1 = new Appointment(patient1, doctor1, AppointmentType.Regular);

            AppointmentContext appointmentContext1 = new AppointmentContext();
            appointmentContext1.ProcessAppointment(appointment1);

            //rutin
            Patient patient2 = new Patient("Hakkı Sancak", 22);
            Doctor doctor2 = new Doctor("Dr. Pelin Akarsu", "Ortopedi");
            Appointment appointment2 = new Appointment(patient2, doctor2, AppointmentType.Routine);

            AppointmentContext appointmentContext2 = new AppointmentContext();
            appointmentContext2.ProcessAppointment(appointment2);
        }
    }
}
