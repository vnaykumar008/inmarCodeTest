using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSkills
{
    public static class fizzbuzz
    {
        public static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
            }
        }
    }
}
