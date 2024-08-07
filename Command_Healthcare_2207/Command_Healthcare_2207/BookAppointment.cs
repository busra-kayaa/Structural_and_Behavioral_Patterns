using System;

namespace Command_Healthcare_2207
{
    internal class BookAppointment : MedicalTransaction
    {
        public override void Execute(object data)
        {
            this.data = data;

            if (data is Appointment appointment)
            {
                Console.WriteLine($"{appointment.Doctor} ile {appointment.Date} tarihinde randevu alındı.");
                patient.AddTransaction(this);
            }
        }

        public override void Undo()
        {
            Console.WriteLine("Randevu rezervasyonu geri alınıyor");
            patient.AddTransaction(this);
        }
        public override string ToString()
        {
            if (data is Appointment appointment)
            {
                return $"Randevu Alma [Hasta={patient.Name}, Doktor={appointment.Doctor.Name}, Tarih={appointment.Date}]";
            }
            return base.ToString();
        }
    }
}