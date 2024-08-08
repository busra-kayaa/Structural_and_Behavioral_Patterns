using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Database_2207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clinic clinic = new Clinic();
            Doctor doctor1 = new Doctor("Dr. Betül YALIN");
            Doctor doctor2 = new Doctor("Dr. Büşra KAYA");
            clinic.AddDoctor(doctor1);
            clinic.AddDoctor(doctor2);

            Patient patient = new Patient("Ayşe Nur Dönmez");
            clinic.AddPatient(patient);

            Receptionist receptionist = new Receptionist();

            IMedicalTransaction bookAppointmentTransaction = new BookAppointment();
            bookAppointmentTransaction.SetPatient(patient);
            bookAppointmentTransaction.Execute(new Appointment(doctor1, DateTime.Now.AddDays(2)));
            Console.WriteLine(patient);
            bookAppointmentTransaction.Undo();
            Console.WriteLine(patient);
            bookAppointmentTransaction.Redo();
            Console.WriteLine(patient);

            IMedicalTransaction prescribeMedicationTransaction = new PrescribeMedication();
            prescribeMedicationTransaction.SetPatient(patient);
            prescribeMedicationTransaction.Execute(new Prescription("Parasetamol", "Her 6 saatte bir tablet alın."));
            Console.WriteLine(patient);
            prescribeMedicationTransaction.Undo();
            Console.WriteLine(patient);
            prescribeMedicationTransaction.Redo();
            Console.WriteLine(patient);

            IMedicalTransaction checkInPatientTransaction = new CheckInPatient();
            checkInPatientTransaction.SetPatient(patient);
            checkInPatientTransaction.Execute(patient);
            Console.WriteLine(patient);
            checkInPatientTransaction.Undo();
            Console.WriteLine(patient);
            checkInPatientTransaction.Redo();
            Console.WriteLine(patient);

            receptionist.HandleInquiry("Size nasıl yardımcı olabilirim?");
            receptionist.HandleInquiry("Randevumu yeniden planlamak istiyorum.");

            List<IMedicalTransaction> transactions = patient.GetTransactions();

            foreach (IMedicalTransaction item in transactions)
                Console.WriteLine(item);

            Console.WriteLine(clinic);
        }
    }
}