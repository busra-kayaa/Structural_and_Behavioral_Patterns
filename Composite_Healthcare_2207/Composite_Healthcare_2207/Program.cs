using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Healthcare_2207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department hospital = new Department("Genel Hastane", "Beyaz");

            IHealthcareProfessional healthcareProfessional = new Doctor("Dr. Büşra Kaya", "Kardiyolog");
            IHealthcareProfessional healthcareProfessional1 = new Nurse("Hemşire Ayşe Nur", "Pediatri");
            IHealthcareProfessional healthcareProfessional2 = new Surgeon("Dr. Fatih Kara", "Ortopedi");
            IHealthcareProfessional healthcareProfessional3 = new Therapist("Dr. Mustafa Korkmaz", "Fizyoterapi");
            IHealthcareProfessional healthcareProfessional4= new Nurse("Hemşire Bera Nur", "Pediatri");

            hospital.AddProfessional(healthcareProfessional);
            hospital.AddProfessional(healthcareProfessional1);
            hospital.AddProfessional(healthcareProfessional2);
            hospital.AddProfessional(healthcareProfessional3);
            hospital.AddProfessional(healthcareProfessional4);
            hospital.AddProfessional(new Doctor("Dr. Büşra Kaya", "Kardiyolog"));

            List<IHealthcareProfessional> professionalList = new List<IHealthcareProfessional>()
            { healthcareProfessional, healthcareProfessional1, healthcareProfessional2, healthcareProfessional3, healthcareProfessional4 };

            hospital.AddProfessionals(professionalList);

            hospital.AttendTraining();
            hospital.PerformDuties();

            hospital.ListProfessionals();
            hospital.RemoveProfessional(healthcareProfessional3);
            Console.WriteLine("\nTerapist silindi...");
            hospital.ListProfessionals();

            hospital.RemoveProfessional(healthcareProfessional1);
            Console.WriteLine("\nHemşire silindi...");
            hospital.ListProfessionals();
        }
    }
}