using Command_Database_2207;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Command_Database_2207
{
    internal class Clinic
    {
        private List<Doctor> doctors;
        private List<Patient> patients;
        private string connectionString = "Server=localhost;Database=healthcaredb;User ID=root;Password=passwordzor;";

        public Clinic()
        {
            doctors = new List<Doctor>();
            patients = new List<Patient>();
        }

        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Doctors (Name) VALUES (@Name)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", doctor.Name);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Patients (Name) VALUES (@Name)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", patient.Name);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Doctor> GetDoctors()
        {
            var doctors = new List<Doctor>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Doctors";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doctors.Add(new Doctor(reader.GetString("Name")));
                        }
                    }
                }
            }
            return doctors;
        }

        public List<Patient> GetPatients()
        {
            var patients = new List<Patient>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Patients";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patients.Add(new Patient(reader.GetString("Name")));
                        }
                    }
                }
            }
            return patients;
        }

        public override string ToString()
        {
            return $"Klinik [Doktorlar={doctors.Count}, Hastalar={patients.Count}]";
        }
    }
}
