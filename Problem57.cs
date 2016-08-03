using System;
using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler
{
    public class BigFrac{
        public BigFrac(BigInteger num, BigInteger dem){
            this.Numerator = num;
            this.Denominator = dem;
        }
        public BigInteger Numerator { get; set; }
        public BigInteger Denominator { get; set; }

        public bool DoesNumeratorHaveMoreDigits(){
            return GetDigitCount(Numerator) > GetDigitCount(Denominator);
        }

        private int GetDigitCount(BigInteger num){
            int count = 0;
            while (num > 0){
                num /= 10;
                count++;
            }

            return count;
        }

        public override string ToString(){
            return string.Format("{0}/{1}", Numerator, Denominator);
        }
    }
    public class Problem57
    {

        public int GetFractionsWithMoreDigitsInNumerator2(){

            int count = 0;
            BigFrac fraction = new BigFrac(new BigInteger(3),new BigInteger(2));
            
            
            for (int i = 1; i < 1000; i++)
            {
                BigInteger tempD = fraction.Denominator,
                    tempN = fraction.Numerator;
                
                fraction.Numerator = tempN + tempD *2;
                fraction.Denominator = fraction.Numerator - tempD;
                if (fraction.DoesNumeratorHaveMoreDigits()){
                    Console.WriteLine("Fraction: {0}", fraction);
                    count++;
                }

            }

            return count;

        }

        

        #region First Attempt

        public int GetFractionsWithMoreDigitsInNumerator(){
            
            List<int> count = new List<int>();
            
            for (int i = 1; i <= 1000; i++)
            {
                var fraction = GetExpansion(i);
                // Console.WriteLine("Fraction {0} = {1}/{2}", i, fraction.Numerator, fraction.Denominator);
                Console.WriteLine(i);
                if (DoesNumeratorHaveMoreDigits(fraction)){
                    Console.WriteLine("Fraction {0} = {1}/{2}", i, fraction.Numerator, fraction.Denominator);
                    count.Add(i);
                }
            }
            
            return count.Count;
        }

        private bool DoesNumeratorHaveMoreDigits(Fraction num){
            return GetDigitCount(num.Numerator) > GetDigitCount(num.Denominator);
        }

        private Fraction GetExpansion(int num){
            return AddFractions(new Fraction{
                Numerator = 1,
                Denominator = 1
            }, GetExpansion(1, num));
        }

        private Fraction GetExpansion(int currentDepth, int maxDepth){
            if (currentDepth == maxDepth){
                return new Fraction{ Numerator = 1, Denominator = 2};
            } 

            // return 1 (reverse) / (2 + previous value) 
            return ReverseFraction(AddFractions(new Fraction{Numerator = 2, Denominator = 1}, 
                GetExpansion(currentDepth + 1, maxDepth))); 
        }

        private int GetDigitCount(int num){
            int count = 0;
            while (num > 0){
                num /= 10;
                count++;
            }

            return count;
        }

        private Fraction AddFractions(Fraction num1, Fraction num2)
        {
            return ReduceFraction(new Fraction{
                Numerator = num1.Numerator * num2.Denominator + num2.Numerator * num1.Denominator,
                Denominator = num1.Denominator * num2.Denominator
            });
        }

        private Fraction ReverseFraction(Fraction num){
            return new Fraction{
                Numerator = num.Denominator,
                Denominator = num.Numerator
            };
        } 

        private Fraction ReduceFraction(Fraction num){
            int max = Math.Max(num.Denominator, num.Numerator),
                half = max / 2;

            for (int i = half; i > 1; i--){
                if (num.Numerator % i == 0 && num.Denominator % i == 0){
                    return ReduceFraction(new Fraction{
                        Numerator = num.Numerator / i,
                        Denominator = num.Denominator / 1
                    });
                }
            }
            
            return num;
        }
    }

    #endregion
    

}