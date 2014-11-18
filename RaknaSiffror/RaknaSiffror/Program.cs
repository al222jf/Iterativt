using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string textNoZero;
            int countZero = 0;
            int countEven = 0;
            int countUneven = 0;
            Console.Write("Mata in ett Heltal: ");
            text = Console.ReadLine();

            foreach(int z in text)
            {
                if(z == '0'){
                    countZero++;
                }
            }

            textNoZero = text.Trim( new Char[] {'0'} );

            foreach (int integer in textNoZero)
            {
                if (integer % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countUneven++;
                }
            }

            Console.WriteLine("Nollor: {0}\nUdda: {1}\nJämna: {2}", countZero, countUneven, countEven);

        }
    }
}
