﻿using System;
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
            Employee employee1 = new Employee();
            employee1.firstName = "Sample";
            employee1.lastName = "Student";
            employee1.SayName();
            Console.ReadLine();
            employee1.Quit();
            Console.WriteLine(employee1.firstName + "... " + employee1.lastName);
            Console.ReadLine();
        }
    }
}