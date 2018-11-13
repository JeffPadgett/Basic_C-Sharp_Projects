using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on? :");
            string courseNumber = Console.ReadLine();

            Console.WriteLine("What page number are you on?: ");
            string pageNumber = Console.ReadLine();

            Console.WriteLine("Do you need help with anything else? Please answer true or false: ");
            string helpAnswer = Console.ReadLine();
            bool helpNeeded = bool.Parse(helpAnswer);

            Console.WriteLine("Where there any positive experiences that you would like to share?: ");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any feedback you would like to provide?: ");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();


            Console.WriteLine("Thank you for your answers! An instructor will respond shortly. Have a great day!");
        }
    }
}
