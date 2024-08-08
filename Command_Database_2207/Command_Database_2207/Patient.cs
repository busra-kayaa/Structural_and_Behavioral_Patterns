using Command_Database_2207;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Command_Database_2207
{
    internal class Patient
    {
        public string Name { get; private set; }
        protected List<IMedicalTransaction> transactions;
        private string connectionString = "Server=localhost;Database=healthcaredb;User ID=root;Password=passwordzor;";

        public Patient(string name)
        {
            Name = name;
            transactions = new List<IMedicalTransaction>();
        }

        public void AddTransaction(IMedicalTransaction transaction)
        {
            transactions.Add(transaction);
            LogTransaction(transaction);
        }

        private void LogTransaction(IMedicalTransaction transaction)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Transactions (PatientID, TransactionType, TransactionData) VALUES (@PatientID, @TransactionType, @TransactionData)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PatientID", GetPatientId());
                    cmd.Parameters.AddWithValue("@TransactionType", transaction.GetType().Name);
                    cmd.Parameters.AddWithValue("@TransactionData", transaction.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private int GetPatientId()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID FROM Patients WHERE Name = @Name";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
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

        public List<IMedicalTransaction> GetTransactions()
        {
            return transactions;
        }

        public override string ToString()
        {
            return $"Hasta [Adı={Name}, İşlem Sayısı={transactions.Count}]";
        }
    }
}
