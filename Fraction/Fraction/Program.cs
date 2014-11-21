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
            Fraction b = new Fraction(6, 4);
            var c = a + b;
            var d = a * b;
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
            Console.WriteLine(d.ToString());
        }
    }
}
