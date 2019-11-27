using PaySlipGenerator.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySlipGenerator.Core.Interfaces
{
    public interface IOutputWriter
    {
        void Write(List<EmployeeMonthlyPaySlip> employeesMonthlyPaySlip);
    }
}
