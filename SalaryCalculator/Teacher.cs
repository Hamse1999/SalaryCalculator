using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculator
{
    internal class Teacher :Emloyee
    {
        public void VariableSalary()
        {


            Console.WriteLine("What is Teacher Pay?");
            Console.ReadLine();
            Console.WriteLine("Enter hours worked:");
            hoursWorked = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter hourly rate:");
            hourlyRate = Convert.ToDouble(Console.ReadLine());
            if (hoursWorked <= 40)
            {
                grossPay = hoursWorked * hourlyRate;
            }
            else
            {
                grossPay = 40 * hourlyRate;
                overtime = (hoursWorked - 40) * (hourlyRate * 1.5);
                grossPay = grossPay + overtime;

            }
            Console.WriteLine("GrossPay: " + grossPay.ToString("C"));
            Console.ReadLine();

        }
    }

}