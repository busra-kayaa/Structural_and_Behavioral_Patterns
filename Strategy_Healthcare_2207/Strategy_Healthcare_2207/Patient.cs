namespace Strategy_Healthcare_2207
{
    internal class Patient
    {
        public string Name { get; set; }
        public int age { get; set; }


        public Patient(string name, int age)
        {
            Name = name;
            this.age = age;
        }
    }
}