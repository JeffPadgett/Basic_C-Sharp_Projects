using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Class_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person(); //test

            Employee Brittany = new Employee("Sample","Student");

            Console.WriteLine(Brittany.firstName);

            Brittany.SayName();
            Console.ReadLine();
        }
    }
}
