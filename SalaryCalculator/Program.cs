using SalaryCalculator;
using System;

namespace SalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Teacher t1 = new Teacher();
            t1.VariableSalary();

            EducationalLeader e1 = new EducationalLeader("EducationalLeader:", 9000, 30000);

            Console.WriteLine("What is EducationalLeader wage:");
            Console.ReadLine();
            Console.WriteLine("Hello " + e1.GetName() + " your salary after taxes is " + e1.BasSalary() + "Kr.");
        }
    }
}
