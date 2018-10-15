using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Class_Method
{
    class Employee : Person
    {

       public Employee(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }
        public int id { get; set; }
    }
}
