using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Range{
        public long Max { get; set; }
        public long Min { get; set; }
    }

    public class Problem41
    {
        public Problem41()
        {
            


            

        }

        public long FindLargestPandigitalPrime()
        {
            var ranges = new List<Range>(){//new Range{ Max = 987654321, Min = 123456789}, 
                new Range{ Max= 87654321, Min = 12345678},
                new Range{ Max = 7654321, Min = 1234567},
                new Range{ Max = 654321, Min = 123456},
                new Range{ Max = 54321, Min = 12345},
                new Range{ Max = 4321, Min = 1234}};

            for(var i = 0; i < ranges.Count; i++)
            {
                var range = ranges[i];

                for(var num = range.Max; num >= range.Min; num--)
                {
                    if (IsPandigital(num, 9 - i - 1) && IsPrime(num))
                    {
                        return num;
                    }
                }
            }

            return 0;
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

        private bool IsPandigital(long num, int maxNum)
        {
            long remainder;

            bool[] flags = new bool[maxNum];
            while (num > 0)
            {
                remainder = num % 10 - 1;
                num = num / 10;
                if (remainder >= maxNum || remainder < 0 || flags[remainder] == true)
                {
                    return false;
                }

                flags[remainder] = true;
            }

            for (int i = 0; i < maxNum; i++)
            {
                if (flags[i] == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
