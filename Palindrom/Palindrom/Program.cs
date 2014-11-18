using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            string reversed = Reverse(value);

            string a = (string) value;
            string b = (string) reversed;

            if (a == b)
            {
                Console.WriteLine("{0} = True", value);
            }
            else
            {
                Console.WriteLine("{0} = False", value);
            }
        }
        public static string Reverse(string str)
        {
            char[] CharArray = str.ToCharArray();
            string reverse = null;
            for(int i = CharArray.Length - 1; i > -1; i--)
            {
                reverse += CharArray[i];
            }
            return reverse;
        }
    }
}
