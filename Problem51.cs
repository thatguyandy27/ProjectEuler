using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler{

    public class Problem51{


        public void TestSieve(){
            DateTime n = DateTime.Now;
            var result = MakeSieve(10000000);

            
        }

        public void BruteForce(){
            var sieve = MakeSieve(10000000);
            List<int> primes = new List<int>();
            for (int i = 0; i < sieve.Length; i++)
            {
                if (sieve[i]){
                    primes.Add(i);
                }
            
            }

            int minCount = 3;
            for (int i = 0; i < primes.Count; i++)
            {
                int prime = primes[i];
                int[] digitCounts = GetDigitCounts(prime);

                if(digitCounts.Any((x) => x >= minCount)){
                    int primeSetCount = GetPrimeSetCount(prime, digitCounts, sieve, minCount);
                    
                    // Console.WriteLine(primeSetCount);
                    if (primeSetCount >= 8){
                        Console.WriteLine(prime);
                        return;
                    }
                }
            }
            
        }

        private int GetPrimeSetCount(int primeToCheck, int[] digitCounts, bool[] primeFlags, int minCount){
            int bestCount = 0;
            
            //TODO figure out what to do with 4s.
            for(int x = 0; x < 10; x++){
                int digitCount = digitCounts[x];
                if (digitCount == minCount){
                    string strPrime = primeToCheck.ToString();
                    
                    int currentCount = 0,
                        digits = (int)Math.Floor(Math.Log10(primeToCheck));
                    for (int i = 0; i < 10; i++)
                    {
                        int newNumber = int.Parse(strPrime.Replace(x.ToString(), i.ToString()));
                      
                        // if(primeToCheck == 121313){
                        //     Console.WriteLine(newNumber);
                        // }
                        if (primeFlags[newNumber]){
                            // make sure sme number of digits. 
                            if ((int)Math.Floor(Math.Log10(newNumber)) != digits){
                                return 0;
                            }
                            // make sure it isn't less than origianal.  If it is then it should have been tried already
                            
                            // if(primeToCheck < newNumber){
                            //     return 0;
                            // }
                            Console.WriteLine(newNumber);
                            currentCount++;
                        }
                    
                    }

                    bestCount = Math.Max(currentCount, bestCount);
                }
            }

            return bestCount;
        }

        private int[] GetDigitCounts(int number){
            int[] count = new int[10];
            // first digit doesn't count... too many 2s
            number /= 10;

            while (number > 0){
                count[number % 10]++;
                number /= 10;
            }

            return count;

        }

        // Build a Sieve of Eratosthenes.
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
    }
}