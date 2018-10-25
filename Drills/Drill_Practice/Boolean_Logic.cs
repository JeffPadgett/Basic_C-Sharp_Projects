using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine("Have you ever had a DUI? Please answer true or false: ");
            string duiInput = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiInput);

            Console.WriteLine("How many speeding tickets do you have? ");
            string speedingTicketsInput = Console.ReadLine();
            int speedingTickets = Convert.ToInt32(speedingTicketsInput);


            bool qualifies = (age >= 15 && dui == false && speedingTickets <= 3);

            Console.WriteLine("Qualified? \n " + qualifies);
            Console.ReadLine();

        }
    }
}
