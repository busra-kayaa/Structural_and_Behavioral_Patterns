using System;

namespace Facade_Healthcare_2207
{
    internal class Room
    {
        private int roomNumber;
        private int capacity;
        private Patient assignedPatient;

        public Room(int roomNumber, int capacity)
        {
            this.roomNumber = roomNumber;
            this.capacity = capacity;
        }

        public void AssignPatient(Patient patient)
        {
            this.assignedPatient = patient;
            Console.WriteLine($"{assignedPatient.GetName()} {roomNumber} numaralı odaya yerleştirildi.");
        }
    }
}