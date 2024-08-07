namespace Strategy_Healthcare_2207
{
    internal class AppointmentContext
    {
        private IAppointmentStrategy emergencyStrategy = new EmergencyAppointmentStrategy();
        private IAppointmentStrategy regularStrategy = new RegularAppointmentStrategy();
        private IAppointmentStrategy routineStrategy = new RoutineAppointmentStrategy();

        public void ProcessAppointment(Appointment appointment)
        {
            switch (appointment.Type)
            {
                case AppointmentType.Emergency:
                    emergencyStrategy.Process(appointment);
                    break;
                case AppointmentType.Regular:
                    regularStrategy.Process(appointment);
                    break;
                case AppointmentType.Routine:
                    routineStrategy.Process(appointment);
                    break;
            }
        }
    }
}