namespace Facade_Healthcare_2207
{
    internal class Patient
    {
        private string name;
        private string surname;
        private int age;

        public Patient(string name,string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public int GetAge()
        {
            return age;
        }
    }
}