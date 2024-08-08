namespace Command_Database_2207
{
    internal class Prescription
    {
        public string Medication { get; private set; }
        public string Dosage { get; private set; }

        public Prescription(string medication, string dosage)
        {
            Medication = medication;
            Dosage = dosage;
        }

        public override string ToString()
        {
            return $"Reçete  [İlaç={Medication}, Dozaj={Dosage}]";
        }
    }
}