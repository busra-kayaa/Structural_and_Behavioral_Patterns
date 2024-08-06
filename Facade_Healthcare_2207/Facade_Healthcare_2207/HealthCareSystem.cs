using System;

namespace Facade_Healthcare_2207
{
    internal class HealthCareSystem
    {
        private Doctor doctor;
        private Patient patient;
        private Appointment appointment;
        private Prescription prescription;
        private Referral referral;
        private Surgery surgery;
        private Room room;
        private Polyclinic polyclinic;
        public HealthCareSystem()
        {
            doctor = new Doctor("Mustafa","Sabancı", "Kardiyoloji");
            patient = new Patient("Cenk", "Yıldız", 45);
            appointment = new Appointment(doctor, patient, DateTime.Now);
            prescription = new Prescription("Aspirin", 95);
            referral = new Referral(patient, "Kardiyoloji");
            surgery = new Surgery("Kalp Ameliyatı", doctor, patient, DateTime.Now.AddDays(1));
            room = new Room(301, 2);
            polyclinic = new Polyclinic("Kardiyoloji", "3. Kat");
        }

        public void Start()
        {
            appointment.Schedule();
            doctor.Diagnose();
            prescription.PrintPrescription();
            referral.IssueReferral();
            surgery.ScheduleSurgery();
            room.AssignPatient(patient);
            polyclinic.RegisterVisit(patient);

            Console.WriteLine("Sağlık sistemi kurulumu tamamlandı.");
        }
        
    }

}