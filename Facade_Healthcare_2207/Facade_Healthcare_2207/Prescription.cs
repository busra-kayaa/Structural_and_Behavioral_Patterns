using System;

namespace Facade_Healthcare_2207
{
    internal class Prescription
    {
        private string medicine;
        private int dose;

        public Prescription(string medicine, int dose)
        {
            this.medicine = medicine;
            this.dose = dose;
        }

        public void PrintPrescription()
        {
            Console.WriteLine($"İlaç: {medicine}, Doz: {dose} mg");
        }

    }
}