using System;

namespace Command_Healthcare_2207
{
    internal class PrescribeMedication : MedicalTransaction
    {
        public override void Execute(object data)
        {
            this.data = data;

            if (data is Prescription prescription)
            {
                Console.WriteLine($"Reçete yayınlandı: {prescription.Medication} - {prescription.Dosage}");
                patient.AddTransaction(this);
            }
        }

        public override void Undo()
        {
            Console.WriteLine("Reçete geri alınıyor");
            patient.AddTransaction(this);
        }
        public override string ToString()
        {
            if (data is Prescription prescription)
            {
                return $"Reçeteli İlaç  [Hasta={patient.Name}, İlaç={prescription.Medication}, Dozaj={prescription.Dosage}]";
            }
            return base.ToString();
        }
    }
}