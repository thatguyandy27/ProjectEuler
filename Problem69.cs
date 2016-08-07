using System;
using System.Collections.Generic;

namespace ProjectEuler{

    public class Problem69{


        public int RealFindMaxValue(){

            int answer = 1,
                max = 1000000;
            var sieve = MakeSieve(max);
        

            for (int i = 2; i < sieve.Length; i++)
            {
                if(sieve[i]){
                    var temp = answer  * i;
                    if(temp <= max){
                        answer = temp;
                    }
                    else{
                        return answer;
                    }
                }
            }

            return -1;

        }

         private bool[] MakeSieve(int max)
        {
            // Make an array indicating whether numbers are prime.
            bool[] is_prime = new bool[max + 1];
            for (int i = 2; i <= max; i++) is_prime[i] = true;

            // Cross out multiples.
            for (int i = 2; i <= max; i++)
            {
                // See if i is prime.
                if (is_prime[i])
                {
                    // Knock out multiples of i.
                    for (int j = i * 2; j <= max; j += i)
                        is_prime[j] = false;
                }
            }
            return is_prime;
        }

        public int FindMaxValue(){
            decimal maxValue = 0;
            int maxValueNumber = 1;
            List<List<int>> factors = new List<List<int>>();

            factors.Add(new List<int>()); // 0
            factors.Add(new List<int>()); // 1
        

            for (int i = 2; i < 1000000; i++)
            {
                var currentFactors = GetFactorsForNumber(i, factors);
                var count = GetCountOfNonSharedFactors(currentFactors, factors);
                decimal currentValue = ((decimal)i) / count; 
                Console.WriteLine("n = {0}, value = {1}", i, currentValue);

                if (currentValue > maxValue){
                    maxValueNumber = i;
                    maxValue = currentValue;
                }

                factors.Add(currentFactors);
            }

            return maxValueNumber;
        }

        public int GetCountOfNonSharedFactors(List<int> currentFactors, List<List<int>> allFactors){
            int count = 1; // always 1
            for (int i = 2; i < allFactors.Count; i++)
            {
                bool found = false;
                foreach (var factorToCheck in allFactors[i])
                {
                    if (currentFactors.Contains(factorToCheck)){
                        found = true;
                        break;
                    }
                }

                if (!found){
                    count++;
                }
            }

            return count;
        }

        public List<int> GetFactorsForNumber(int number, List<List<int>> factors){
            int index = number / 2;
            List<int> currentFactors = new List<int>();

            while (index > 1){
                if (number % index == 0){
                    // Console.WriteLine(index);
                    currentFactors.AddRange(factors[index]);
                    number /= index;
                    if(!currentFactors.Contains(number)){
                        currentFactors.Add(number);
                    }

                    return currentFactors;
                }
                else {
                    index--;
                }
            };

            // it is prime
            return new List<int>{number};
        }
    }
}