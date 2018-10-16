using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee<string> employee2 = new Employee<string>();
            employee2.firstName = "Harry";
            employee2.lastName = "soulis";
            employee2.employeeID = 1462;
            employee2.things = new List<string>() { "badge ", "coffee cup ", "comb " };

            Employee<int> employee3 = new Employee<int>();
            employee3.firstName = "Brian";
            employee3.lastName = "Ducky";
            employee3.employeeID = 1462;
            employee3.things = new List<int>() { 10, 241, 9 };

            foreach (string thing in employee2.things)
            {
                Console.WriteLine("I brought my " + thing + "to work");
            }

            foreach (int thing in employee3.things)
            {
                Console.WriteLine("Number of things: " + thing);
            }


            Console.ReadLine();



        }
    }
}
