using System;
using System.Collections.Generic;


namespace ProjectEuler
{
    public class Problem92{

        public int GetCount(int max = 10000000){
            int[] chainResults = new int[max];
            int count = 0;

            for (int i = 1; i < max; i++)
            {
                int result = GetChainNumber(i, chainResults);
                //  Console.WriteLine("{0} = {1}", i, result);
                if (result == 89){
                    count++;
                }
            }

            return count;
        }

        private int GetChainNumber(int number, int[] chainResults){
            if (number < chainResults.Length && chainResults[number] != 0){
                return chainResults[number];
            }

            int nextNumber = GetNexNumber(number);
            if (nextNumber == 1 || nextNumber == 89){
                //  Console.WriteLine("B: {0} => {1}", number, nextNumber);
                chainResults[number] = nextNumber;
                return nextNumber;
            }
            else{
                var result = GetChainNumber(nextNumber, chainResults);
                chainResults[number] = result;
                //  Console.WriteLine("{0}: {1}: {2}", number, result, nextNumber);
                return result;
            }
        }

        private int GetNexNumber(int number){
            int nextNumber = 0;

            while (number > 0){
                var mod = number % 10;
                nextNumber += mod*mod;
                number /= 10;
            }

            return nextNumber;
        }
    }
}