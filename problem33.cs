using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem33
    {


        public Fraction[] FindNonTrivialFractions()
        {
            Fraction[] result = new Fraction[4];
            int index = 0;

            for (int denominator = 10; denominator < 100; denominator++)
            {
                var fraction = FindNonTrivialFraction(denominator);
                if (fraction != null)
                {
                    result[index++] = fraction;
                    if (index == 4)
                    {
                        break;
                    }
                }

            }

            return result;
        }

        private Fraction FindNonTrivialFraction(int denominator)
        {
            int denominatorTens = denominator / 10,
                denominatorOnes = denominator - denominatorTens * 10;

            Fraction result = null;

            // gonna ignore 0s for now)
            if (denominatorOnes == 0)
            {
                return null;
            }


            for (int numerator = 10; numerator < denominator; numerator++)
            {
                //find easy examples
                int numeratorTens = numerator / 10;
                int numeratorOnes = numerator - numeratorTens * 10;

                if (denominatorTens == numeratorOnes)
                {
                    var actualResult = numerator / (decimal)denominator;
                    var tempResult = numeratorTens / (decimal)denominatorOnes;

                    if (actualResult == tempResult)
                    {
                        Console.WriteLine(string.Format("{0}/{1} = {2}/{3}", numerator, denominator, numeratorTens, denominatorOnes));

                        result = new Fraction { Denominator = denominator, Numerator = numerator };
                    }

                }
            }

            return result;
        }
    }

    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
    }
}
