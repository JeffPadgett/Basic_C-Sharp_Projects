using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {

        public struct BigMoney
        {
            public decimal amount;
        }

        static void Main(string[] args)
        {
            BigMoney bank = new BigMoney();
            bank.amount = 100m;
        }
    }
}
