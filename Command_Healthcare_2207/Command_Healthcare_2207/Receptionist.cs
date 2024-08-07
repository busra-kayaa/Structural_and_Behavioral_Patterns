using System;

namespace Command_Healthcare_2207
{
    internal class Receptionist
    {
        public void HandleInquiry(string inquiry)
        {
            Console.WriteLine($"Resepsiyon görevlisinin sorgulaması: {inquiry}");
        }
    }
}