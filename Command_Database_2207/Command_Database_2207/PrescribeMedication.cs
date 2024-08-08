using Command_Database_2207;
using MySql.Data.MySqlClient;
using System;

namespace Command_Database_2207
{
    internal class PrescribeMedication : MedicalTransaction
    {
        private string connectionString = "Server=localhost;Database=healthcaredb;User ID=root;Password=passwordzor;";

        public override void Execute(object data)
        {
            this.data = data;

            if (data is Prescription prescription)
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Prescriptions (PatientID, Medication, Dosage) VALUES (@PatientID, @Medication, @Dosage)";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", GetPatientId(patient.Name));
                        cmd.Parameters.AddWithValue("@Medication", prescription.Medication);
                        cmd.Parameters.AddWithValue("@Dosage", prescription.Dosage);
                        cmd.ExecuteNonQuery();
                    }
                }

                Console.WriteLine($"Reçete yayınlandı: {prescription.Medication} - {prescription.Dosage}");
                patient.AddTransaction(this);
            }
        }

        public override void Undo()
        {
            if (data is Prescription prescription)
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Prescriptions WHERE PatientID = @PatientID AND Medication = @Medication AND Dosage = @Dosage LIMIT 1";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", GetPatientId(patient.Name));
                        cmd.Parameters.AddWithValue("@Medication", prescription.Medication);
                        cmd.Parameters.AddWithValue("@Dosage", prescription.Dosage);
                        cmd.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Reçete geri alınıyor");
                patient.AddTransaction(this);
            }
        }

        public override string ToString()
        {
            if (data is Prescription prescription)
            {
                return $"Reçeteli İlaç  [Hasta={patient.Name}, İlaç={prescription.Medication}, Dozaj={prescription.Dosage}]";
            }
            return base.ToString();
        }

        private int GetPatientId(string patientName)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID FROM Patients WHERE Name = @Name";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", patientName);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32("ID");
                        }
                    }
                }
            }
            throw new Exception("Patient not found");
        }
    }
}
