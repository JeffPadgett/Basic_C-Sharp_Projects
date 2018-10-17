using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }



        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Please enter the day of the week");
                DaysOfTheWeek userChoice = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter in the correct data type");
            }
            finally
            {
                Console.ReadLine();
            }

            

  


        }
    }
}
