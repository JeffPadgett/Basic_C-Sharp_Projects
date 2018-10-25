using System;
using System.Collections.Generic;




class Program
{
    static void Main()
    {
        string[] stringArray = new string[] { "string one", "string two", "string three" };
        int[] intArray = new int[] { 23, 653, 7781, 3543, 6 };
        List<string> stringList = new List<string>();
        stringList.Add("This is the first string.");
        stringList.Add("This is the second string.");
        stringList.Add("This is the third string.");

        Console.WriteLine("Please select an index of the string array 1-3: ");
        int stringArrayInput = Convert.ToInt16(Console.ReadLine());

        switch (stringArrayInput)
        {

            case 1:
                Console.WriteLine("You choose " + stringArray[0]);
                break;

            case 2:
                Console.WriteLine("You choose " + stringArray[1]);
                break;

            case 3:
                Console.WriteLine("You choose " + stringArray[2]);
                break;

            case 4:
                Console.WriteLine("You choose " + stringArray[3]);
                break;

            case 5:
                Console.WriteLine("You choose " + stringArray[4]);
                break;

        }

        Console.WriteLine("Please select an index of the integer array by typing a 1 digit number from 1 to 5: ");
        int intArrayInput = Convert.ToInt16(Console.ReadLine());

        switch (intArrayInput)
        {

            case 1:
                Console.WriteLine("You choose " + intArray[0]);
                break;

            case 2:
                Console.WriteLine("You choose " + intArray[1]);
                break;

            case 3:
                Console.WriteLine("You choose " + intArray[2]);
                break;

        }

        Console.WriteLine("Please select an index of the string list by typing a 1 digit number from 1 to 3: ");
        int stringListInput = Convert.ToInt16(Console.ReadLine());

        switch (stringListInput)
        {

            case 1:
                Console.WriteLine("You choose " + stringList[0]);
                break;

            case 2:
                Console.WriteLine("You choose " + stringList[1]);
                break;

            case 3:
                Console.WriteLine("You choose " + stringList[2]);
                break;

        }
        Console.WriteLine("\n\nThank you for participating.");
        Console.ReadLine();

    }
}

