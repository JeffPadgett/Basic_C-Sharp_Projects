using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features
{
    class Program
    {
        public class Human
        {
            const string sex = "male";
            public string Name { get; set; }
            public int Age { get; set; }
            public string HairColor { get; set; }

            public Human(string name, int age, string hairColor)
            {
                Age = age;
                Name = name;
                HairColor = hairColor;
            }

            public Human(string name) : this(name, 50, "brown")
            {

            }

            public Human(int age) : this("bob", age, "brown")
            {

            }
        }


        static void Main(string[] args)
        {
            var ceo = new Human("Henry");
            Console.WriteLine(ceo.Name + " " + ceo.Age + " " + ceo.HairColor);
            Console.ReadLine();

        }
    }
}
