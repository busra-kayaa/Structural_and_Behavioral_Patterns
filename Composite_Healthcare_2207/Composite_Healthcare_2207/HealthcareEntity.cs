namespace Composite_Healthcare_2207
{
    internal abstract class HealthcareEntity : IHealthcareProfessional
    {
        protected string name;
        protected string specialization;

        protected HealthcareEntity(string name, string specialization)
        {
            this.name = name;
            this.specialization = specialization;
        }

        public abstract void PerformDuties();
        public abstract void TakeBreak();
        public abstract void AttendTraining();

        public override string ToString()
        {
            return $"{name} ({specialization})";
        }
    }
}