using PaySlipGenerator.Core.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySlipGenerator.Core.Interfaces
{
    public interface IEmployeePaySlipService
    {
        List<EmployeeMonthlyPaySlip> GetEmployeesPaySlip(StreamReader fileStream, FileExtensionType fileExtensionType);
    }
}
