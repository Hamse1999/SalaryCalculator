using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculator
{
    internal class Emloyee
    {
        public double grossPay { get; set; }
        public double overtime { get; set; }
        public double hourlyRate { get; set; }
        public double hoursWorked { get; set; }

        public int Tax { get; set; }

        public int Wage { get; set; }

        public string Name;
    }
}
