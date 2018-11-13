using System;
using System.Collections.Generic;

class Program
    {
        static void Main()
        {
            List<string> groceryList = new List<string>() { "Onions", "Cucumbers", "Orange Juice", "Onions", "Pineapple", "Pineapple" };

            int index = 0;

            foreach (string grocery in groceryList)
            {
            Console.WriteLine(grocery);
                for (int i = 0; i < groceryList.Count; i++)
                {
                Console.WriteLine("        " + groceryList[i]);

                    if (groceryList[i] == grocery && index > i)
                    {
                        Console.WriteLine(grocery + " already appears in the list");
                    }
                }
                index++;
            }
            Console.ReadLine();
    }
    }

