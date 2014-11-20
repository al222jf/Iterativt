using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Fraction a = new Fraction(7, 2);
            Fraction b = new Fraction(6, 0);

            Console.WriteLine(a.ToString());
        }
    }
}
