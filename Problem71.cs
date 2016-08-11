using System;

namespace ProjectEuler
{
    public class Problem71{

        public int FindNumerator(){
            decimal fractionToFind = 3.0M/7.0M;
            decimal currentFraction = .4M;
            int numerator = 2, 
                denominator = 5;

            for (int i = 8; i < 1000000; i++){
                var initalNum = Math.Ceiling(i*fractionToFind);
                for(decimal j = initalNum; j > 0; j--){
                    var result = j / i;
                    // found to the left of fractionToFind
                    if (result < fractionToFind){
                        if (result > currentFraction){
                            // Console.WriteLine(result);
                            // Console.WriteLine(fractionToFind);
                            // found new value
                            currentFraction = result;
                            numerator = (int)j;
                            denominator = i;
                        }

                        break;
                    }
                }
            }
            Console.WriteLine(fractionToFind);
            Console.WriteLine("{0}/{1} = {2}", numerator, denominator, fractionToFind);
            return numerator;
        }
    }
}