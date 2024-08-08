using System;
using System.Collections.Generic;

namespace Command_Database_2207
{
    internal abstract class MedicalTransaction : IMedicalTransaction
    {
        protected Patient patient;
        protected object data;

        public void Redo()
        {
            Execute(data);
        }

        public List<IMedicalTransaction> GetTransactions()
        {
            return patient.GetTransactions();
        }

        public void SetPatient(Patient patient)
        {
            this.patient = patient;
        }

        public override string ToString()
        {
            return $"{this.GetType()} [Hasta={patient.Name}, Tarih={data}]";
        }

        public abstract void Execute(object data);
        public abstract void Undo();
    }
}
