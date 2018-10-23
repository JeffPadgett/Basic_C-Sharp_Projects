using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    class Program
    {

            static List<Employee> listEmployees = new List<Employee>()
        {
            new Employee { ID = 101, firstName = "Joe", lastName = "Padgett" },
            new Employee { ID = 102, firstName = "Casey", lastName = "Anthom" },
            new Employee { ID = 103, firstName = "Anthony", lastName = "Locus" },
            new Employee { ID = 104, firstName = "Ashley", lastName = "Gene" },
            new Employee { ID = 105, firstName = "Lisa", lastName = "Spring" },
            new Employee { ID = 106, firstName = "Brandon", lastName = "Miller" },
            new Employee { ID = 107, firstName = "Brittany", lastName = "Padgett" },
            new Employee { ID = 108, firstName = "Patrick", lastName = "Hangover" },
            new Employee { ID = 109, firstName = "Mark", lastName = "Synoc" },
            new Employee { ID = 110, firstName = "Joe", lastName = "Smith" }
        };

        static List<Employee> joeEmployees = new List<Employee>();

        static void Main(string[] args)
        {
            
            foreach (Employee employee in listEmployees)
            {
                if (employee.firstName == "Joe")
                {
                    joeEmployees.Add(employee);
                }
            }
            Console.WriteLine("Employees:{0} {1}, {2} {3} ", joeEmployees[0].firstName, joeEmployees[0].lastName, joeEmployees[1].firstName, joeEmployees[1].lastName );
            Console.ReadLine();

            List<Employee> joeList = listEmployees.Where(x => x.firstName == "Joe").ToList();
            List<Employee> listId = listEmployees.Where(x => x.ID >= 105).ToList();
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", listId[0].firstName, listId[1].firstName, listId[2].firstName, listId[3].firstName, listId[4].firstName);
            Console.ReadLine();



        }
    }
}
