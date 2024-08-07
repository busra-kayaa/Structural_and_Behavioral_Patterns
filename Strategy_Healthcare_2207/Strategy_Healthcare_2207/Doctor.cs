namespace Strategy_Healthcare_2207
{
    internal class Doctor
    {
        public string Name { get; set; }
        public string Specialty { get; set; }

        public Doctor(string name, string specialty)
        {
            Name = name;
            Specialty = specialty;
        }
    }
}