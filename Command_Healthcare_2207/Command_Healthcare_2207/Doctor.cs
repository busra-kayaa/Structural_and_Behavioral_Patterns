namespace Command_Healthcare_2207
{
    internal class Doctor
    {
        public string Name { get; private set; }

        public Doctor(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Doktor [Adı={Name}]";
        }
    }
}