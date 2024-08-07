using System.Collections.Generic;

namespace Command_Healthcare_2207
{
    internal interface IMedicalTransaction
    {
        void Execute(object data);
        void Undo();
        void Redo();
        List<IMedicalTransaction> GetTransactions();
        void SetPatient(Patient patient);
    }
}