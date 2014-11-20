using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fraction
    {
        int _numerator;
        int _denominator;

        public Fraction(int numerator, int denominator)
        {
            getNumerator = numerator;
            getDenominator = denominator;


        }

        public int getNumerator
        {
            get { return _numerator; }
            set 
            {
                if (value == 0)
                {
                    throw new ArgumentException("Inga nollor i täljaren!");
                }
                _numerator = value;
            }

        }

        public int getDenominator
        {
            get { return _denominator; }
            set 
            {
                _denominator = value;
            }

        }

        public bool isNegative()
        {    
            if( _numerator < 0 || _denominator < 0){
                return true;

            } 
            else
            {
                return false;
            }
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int addedNumerator = a.getNumerator * b.getDenominator + b.getNumerator * a.getDenominator;
            int addedDenominator = a.getDenominator * b.getDenominator;

            return new Fraction(addedNumerator, addedDenominator);
        }

        public static Fraction operator*(Fraction a, Fraction b)
        {
            int multiplyedNumerator = a.getNumerator * b.getNumerator;
            int multiplyedDenominator = a.getDenominator * b.getDenominator;

            return new Fraction(multiplyedNumerator, multiplyedDenominator);
        }

        public bool isEqualTo(Fraction a, Fraction b)
        {
           if(Fraction a == Fraction b)
           {

           }
        }

        public override string ToString(){
            return string.Format("{0}/{1}", _numerator, _denominator);
        }
    }
}
