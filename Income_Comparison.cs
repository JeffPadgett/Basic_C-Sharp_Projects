using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Force
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1 \n Please state your hourly rate: ");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Please state the hours worked per week: ");
            string hoursWorked1 = Console.ReadLine();
            Console.WriteLine("Thank you person 1");

            Console.WriteLine("Person 2 \n Please state your hourly rate: " );
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Please state the hours worked per week: ");
            string hoursWorked2 = Console.ReadLine();
            Console.WriteLine("Thank you person 2");

            int weeklySalary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hoursWorked1);
            int weeklySalary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hoursWorked2);

            Console.WriteLine("Weekly Salary of Person 1: \n " + weeklySalary1);
            Console.WriteLine("Weekly Salary of Person 2: \n " + weeklySalary2);

            bool moreSalary = weeklySalary1 > weeklySalary2;

            Console.WriteLine("Does person 1 make more money than person 2: \n" + moreSalary );
            Console.ReadLine();



        }
    }
}
