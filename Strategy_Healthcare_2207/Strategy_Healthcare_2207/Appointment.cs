namespace Strategy_Healthcare_2207
{
    internal class Appointment
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public AppointmentType Type { get; set; }

        public Appointment(Patient patient, Doctor doctor, AppointmentType type)
        {
            Patient = patient;
            Doctor = doctor;
            Type = type;
        }
    }
    public enum AppointmentType
    {
        Emergency,
        Regular,
        Routine
    }
}