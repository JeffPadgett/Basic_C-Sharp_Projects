using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Try_Catch
{
    class Program
    {

        static void Main(string[] args)
        {
            int age = 0;
            bool correctUserInput = false;

            try
            {
                Console.WriteLine("What is your age?");
                while (!correctUserInput)
                {
                    correctUserInput = int.TryParse(Console.ReadLine(), out age);
                    if (age < 0) throw new ArgumentNullException();                        
                    if (!correctUserInput) Console.WriteLine("Please enter your name as a whole number, no decimals");
                }

                int yearBorn = Convert.ToInt32(DateTime.Today.Year) - age;
                Console.WriteLine("You were born in the year {0}.", yearBorn);
                Console.ReadLine();
            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("You entered in a negative or incorrect number, please enter in a postive or whole number");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please contact the game administrator" );
                Console.ReadLine();
            }
        }
    }
}
