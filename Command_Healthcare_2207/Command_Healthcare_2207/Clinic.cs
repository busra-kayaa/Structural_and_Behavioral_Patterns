using System.Collections.Generic;

namespace Command_Healthcare_2207
{
    internal class Clinic
    {
        private List<Doctor> doctors;
        private List<Patient> patients;

        public Clinic()
        {
            doctors = new List<Doctor>();
            patients = new List<Patient>();
        }

        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public override string ToString()
        {
            return $"Klinik [Doktorlar={doctors.Count}, Hastalar={patients.Count}]";
        }
    }
}