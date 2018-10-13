using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
       
        try
        { 
            List<int> dividedNumbers = new List<int>() { 14, 98, 125, 83, 7, 10 };
            Console.WriteLine("Please enter a number to divide with: ");
            int userInput = Convert.ToInt32(Console.ReadLine());


        
        
            for (int i = 0; i < dividedNumbers.Count; i++)
        {
                int sum = dividedNumbers[i] / userInput;

                Console.WriteLine(sum);
                Console.ReadLine();
        }

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please divide by a whole number.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a number");
        }
        finally
        {
            Console.WriteLine("The program has is going to proceed");
            Console.ReadLine();
        }
        

    }
}

