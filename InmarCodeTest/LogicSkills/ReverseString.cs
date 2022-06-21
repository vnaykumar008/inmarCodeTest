using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSkills
{
    public static class ReverseString
    {
        public static void ReverseStr()
        {
            using System.Linq;

            var str = Console.ReadLine();
            char[] result = new char[str.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                result[i] = str[j];
            }
            Console.WriteLine(result);
        }
    }

}
