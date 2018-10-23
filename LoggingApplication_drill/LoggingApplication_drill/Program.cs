using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggingApplication_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int numberToLog = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\jp171\Documents\visual studio 2015\Projects\LoggingApplication_drill\LoggingApplication_drill\Logs\log.txt", true))
            {
                file.WriteLine(numberToLog);
            }
            Console.ReadLine();
        }
    }
}
