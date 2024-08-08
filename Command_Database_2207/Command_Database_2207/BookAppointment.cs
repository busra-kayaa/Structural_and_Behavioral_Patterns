using Command_Database_2207;
using MySql.Data.MySqlClient;
using System;

namespace Command_Database_2207
{
    internal class BookAppointment : MedicalTransaction
    {
        private string connectionString = "Server=localhost;Database=healthcaredb;User ID=root;Password=passwordzor;";

        public override void Execute(object data)
        {
            this.data = data;

            if (data is Appointment appointment)
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Appointments (PatientID, DoctorID, Date) VALUES (@PatientID, @DoctorID, @AppointmentDate)";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", GetPatientId(patient.Name));
                        cmd.Parameters.AddWithValue("@DoctorID", GetDoctorId(appointment.Doctor.Name));
                        cmd.Parameters.AddWithValue("@AppointmentDate", appointment.Date);
                        cmd.ExecuteNonQuery();
                    }
                }

                Console.WriteLine($"{appointment.Doctor} ile {appointment.Date} tarihinde randevu alındı.");
                patient.AddTransaction(this);
            }
        }

        public override void Undo()
        {
            if (data is Appointment appointment)
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Appointments WHERE DoctorID = @DoctorID AND PatientID = @PatientID AND Date = @Date LIMIT 1";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@DoctorID", GetDoctorId(appointment.Doctor.Name));
                        cmd.Parameters.AddWithValue("@PatientID", GetPatientId(patient.Name));
                        cmd.Parameters.AddWithValue("@Date", appointment.Date);
                        cmd.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Randevu rezervasyonu geri alınıyor");
                patient.AddTransaction(this);
            }
        }

        public override string ToString()
        {
            if (data is Appointment appointment)
            {
                return $"Randevu Alma [Hasta={patient.Name}, Doktor={appointment.Doctor.Name}, Tarih={appointment.Date}]";
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
            throw new Exception("Hasta bulunamadı");
        }

        private int GetDoctorId(string doctorName)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID FROM Doctors WHERE Name = @Name";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", doctorName);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32("ID");
                        }
                    }
                }
            }
            throw new Exception("Doctor not found");
        }
    }
}
