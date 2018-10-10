using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Guess a number: from 1 to 5: ");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
            bool notGuessed = false;

            do
            {

                switch (guessedNumber)
                {
                    case 1:
                        Console.WriteLine("You guessed 1.. Please guess again");
                        Console.WriteLine("Guess another number ");
                        guessedNumber = Convert.ToInt32(Console.ReadLine());
                        break;


                    case 2:

                        Console.WriteLine("you guessed 1..try again");
                        Console.WriteLine("Guess another number ");
                        guessedNumber = Convert.ToInt32(Console.ReadLine());
                        break;


                    case 3:

                        Console.WriteLine("You won! You guessed it correctly! ");
                        notGuessed = true;
                        break;

                    case 4:

                        Console.WriteLine("you guessed 1..try again");
                        Console.WriteLine("Guess another number ");
                        guessedNumber = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:

                        Console.WriteLine("you guessed 1..try again");
                        Console.WriteLine("Guess another number ");
                        guessedNumber = Convert.ToInt32(Console.ReadLine());
                        break;


                }
            }

            while (!notGuessed);
            

            Console.ReadLine();
        }
    }
}
