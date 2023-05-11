using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageBuilderArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilderArray.addCompanyEmpWage("Reliance", 20, 50, 60);

            empWageBuilderArray.computeEmpWage();

        }
    }
}
