using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageBuilderArray
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingdays;
        public int maxHourPermonth;
        public int totalEmpWage;
        public CompanyEmpWage(string company,int empRatePerHour, int numOfWorkingdays,int totalEmpWage)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.totalEmpWage = totalEmpWage;
            this.numOfWorkingdays = numOfWorkingdays;
            this.maxHourPermonth = maxHourPermonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp wage for company : " + this.company + " is : "  + this .totalEmpWage;
        }
    }
}
