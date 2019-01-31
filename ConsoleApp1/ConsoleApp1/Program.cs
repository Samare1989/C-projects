using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { static void UseForToSumNumber()
        {
            var total = 0;
            for(var idx = 0; idx < 10; idx = idx +1)
            {
                total = total + idx;
            }
            Console.WriteLine($"Total is {total}");
        }
        static void Main(string[] args)
        {
        }
    }
}
