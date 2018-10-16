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
            //Employee employee1 = new Employee();
            //employee1.firstName = "Sample";                        
            //employee1.lastName = "Student";
            //employee1.SayName();
            //Console.ReadLine();
            //employee1.Quit();
            //Console.WriteLine(employee1.firstName + "... " + employee1.lastName);
            //Console.ReadLine();

            Employee employee2 = new Employee();
            employee2.firstName = "Harry";
            employee2.lastName = "soulis";
            employee2.employeeID = 1462;

            Employee employee3 = new Employee();
            employee3.firstName = "Brian";
            employee3.lastName = "Ducky";
            employee3.employeeID = 1462;

            bool doesEqual = employee2 == employee3; //overloaded operater method. 

            Console.ReadLine();



        }
    }
}
