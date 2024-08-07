using System;

namespace Command_Healthcare_2207
{
    internal class CheckInPatient : MedicalTransaction
    {
        public override void Execute(object data)
        {
            this.data = data;

            if (data is Patient patient)
            {
                Console.WriteLine($"Hasta {patient.Name} kliniğe giriş yaptı.");
                patient.AddTransaction(this);
            }
        }

        public override void Undo()
        {
            Console.WriteLine($"Hasta kaydı geri alınıyor: {patient.Name}");
            patient.AddTransaction(this);
        }
        public override string ToString()
        {
            return $"Hasta Kayıt [Hasta={patient.Name}]";
        }
    }
}