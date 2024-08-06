using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Healthcare_2207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HealthCareSystem healthCareSystem = new HealthCareSystem();
            healthCareSystem.Start();
        }
    }
}
