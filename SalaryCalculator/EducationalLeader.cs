using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SalaryCalculator
{
    internal class EducationalLeader :Emloyee
    {
        public EducationalLeader(string name, int tax, int wage)
        {
            this.Name = name;
            this.Tax = tax;
            this.Wage = wage;
        }

        public int BasSalary()
        {

            return Wage - Tax;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
