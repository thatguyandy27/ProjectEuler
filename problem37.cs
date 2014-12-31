using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem37
    {
        HashSet<long> _primes = new HashSet<long>();

        public long[] GetTruncatablePrimes()
        {
            var truncatablePrimes = new long[11];
            int currentIndex = 0;
            long numberIndex = 3;
            _primes.Add(2);


            while (currentIndex != 11)
            {
                if (IsPrime(numberIndex))
                {
                    _primes.Add(numberIndex);

                    if (IsTruncatablePrime(numberIndex))
                    {
                        Console.WriteLine("Found " + numberIndex);
                        truncatablePrimes[currentIndex] = numberIndex;
                        currentIndex++;
                    }
                }


                numberIndex += 2;
            }


            return truncatablePrimes;
        }

        private bool IsTruncatablePrime(long num)
        {
            return (num > 10 && IsTruncatablePrimeRight(num) && 
                IsTruncatablePrimeLeft(num) );
        }

        private bool IsTruncatablePrimeLeft(long num)
        {
            // fix if awful
            var numString = num.ToString();


            numString = numString.Substring(1, numString.Length - 1);
            while (numString.Length > 0)
            {
                if (!_primes.Contains(long.Parse(numString)))
                {
                    return false;
                }
                numString = numString.Substring(1, numString.Length - 1);
            }

            return true;
        }

        private bool IsTruncatablePrimeRight(long num)
        {
            
            while (num > 10)
            {
                num = num / 10;

                if (!_primes.Contains(num))
                {
                    return false;
                }
            }

            return true;
        }


        private bool IsPrime(long num)
        {
            var max = Math.Sqrt(num);
            if ((num & 1) == 0)
            {
                return (num == 2);
            }

            for (int i = 3; i <= max; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
