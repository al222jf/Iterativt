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

        public static Fraction operator *(Fraction a, Fraction b)
        {

        }

        public multiply(){

        }

        public isEqualTo(){

        }

        public toSting(){

        }
    }
}
