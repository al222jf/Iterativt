using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int count_a = 0;
            int count_A = 0;

            text = Console.ReadLine();

            foreach (char a in text)
            {
                if (a == 'a')
                {
                    count_a++;
                }
            }

            foreach (char A in text)
            {
                if (A == 'A')
                {
                    count_A++;
                }
            }

            Console.WriteLine("Antal a: {0}\nAntal A: {1}", count_a, count_A);
        }
    }
}
