using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Healthcare_2207
{
    internal interface IHealthcareUnit
    {
        void AddProfessional(IHealthcareProfessional professional);
        void AddProfessionals(List<IHealthcareProfessional> professionals);
        void RemoveProfessional(IHealthcareProfessional professional);
        List<IHealthcareProfessional> GetProfessionals();
        void ListProfessionals();
    }
}
