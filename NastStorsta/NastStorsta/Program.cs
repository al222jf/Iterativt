using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastStorsta
{
    class Program
    {
        static void Main(string[] args)
        {
            int higest = 0;
            int secondHigest = 0;
            int value;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ange heltal: ");
                value = int.Parse(Console.ReadLine());

                if (value > higest)
                {
                    secondHigest = higest;
                    higest = value;
                } 
                else if (value > secondHigest && value < higest)
                {
                    secondHigest = value;
                }
            }
            Console.WriteLine("Det näst största talet är: {0}", secondHigest);
        }
    }
}
