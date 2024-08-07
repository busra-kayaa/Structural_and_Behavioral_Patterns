using System.Collections.Generic;

namespace Command_Healthcare_2207
{
    internal class Patient
    {
        public string Name { get; private set; }
        protected List<IMedicalTransaction> transactions;

        public Patient(string name)
        {
            Name = name;
            transactions = new List<IMedicalTransaction>();
        }

        public void AddTransaction(IMedicalTransaction transaction)
        {
            transactions.Add(transaction);
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