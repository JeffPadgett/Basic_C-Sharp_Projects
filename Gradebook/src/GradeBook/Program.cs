using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() {38.48, 42.4, 2.3};
            grades.Add(56.1);

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");

            if(args.Length > 0)
            {
            Console.WriteLine($"Hello, {args[0]}");
            }
            else 
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
