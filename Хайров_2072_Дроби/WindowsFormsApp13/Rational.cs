using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    public partial class Rational
    {

        public int numerator;
        public int delimeter;

        public Rational(int numerator, int delimeter)
        {
            this.numerator = numerator;
            this.delimeter = delimeter;
        }

        public static Rational operator +(Rational first, Rational second)
        {
            int numerator = first.numerator * second.delimeter + second.numerator * first.delimeter;
            int delimeter = first.delimeter * second.delimeter;
            return (new Rational(numerator, delimeter));
        }

        public static Rational operator -(Rational first, Rational second)
        {
            int numerator = first.numerator * second.delimeter - second.numerator * first.delimeter;
            int delimeter = first.delimeter * second.delimeter;
            return (new Rational(numerator, delimeter));
        }

        public static Rational operator *(Rational first, Rational second)
        {
            int numerator = first.numerator * second.numerator;
            int delimeter = first.delimeter * second.delimeter;
            return (new Rational(numerator, delimeter));
        }

        public static Rational operator /(Rational first, Rational second)
        {
            int numerator = first.numerator * second.delimeter;
            int delimeter = first.delimeter * second.numerator;
            return (new Rational(numerator, delimeter));
        }

        public void reduction()
        {
            int c = 2;

            while (c > 1)
            {
                double a = numerator;
                double b = delimeter;
                while (a * b != 0)
                {
                    if (a > b)
                        a = a % b;
                    else
                        b = b % a;

                }
                c = Convert.ToInt32(a + b);
                numerator = numerator / c;
                delimeter = delimeter / c;
            }
        }
        public static Rational reduction(Rational rational)
        {
            rational.reduction();
            
            return new Rational(rational.numerator,rational.delimeter);
        }
        public Rational Reduction()
        {
            reduction();
            return new Rational(numerator, delimeter);
        }
    }
}
