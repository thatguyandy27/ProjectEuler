using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem32
    {
        HashSet<long> Results = new HashSet<long>();

        public HashSet<long> GetPandigitalProducts()
        {

            for (long a = 1; a < 10000; a++)
            {
                for (long b = 1; b < 10000; b++)
                {
                    var product = a * b;

                    if (!Results.Contains(product) && IsPandigital(ConcatNumbers(product, a, b)))
                    {
                        Results.Add(product);
                    }
                }
               
            }

            return Results;
        }

        private long ConcatNumbers(params long[] numbers)
        {
            long num0 = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                long num1 = numbers[i];

                while (num1 > 0)
                {
                    num0 = num0 * 10;
                    num0 += num1 % 10;
                    num1 = num1 / 10;
                }
            }

            return num0;
        }


        private bool IsPandigital(long num)
        {
            bool[] numbersUsed = new bool[] { false, false, false, false, false, false, false, false, false };

            

            
            for(var count = 0; count < 9; count++)
            {
                var remainder = num % 10;
                num = num / 10;

                if (remainder == 0 || numbersUsed[remainder - 1])
                {
                    return false;
                }

                numbersUsed[remainder - 1] = true;

            }

            if (num > 0)
            {
                return false;
            }
            return true;
        }


        //private bool IsPandigitialProduct(int number, List<int> remainingDigits)
        //{
        //    for (var i = 0; i < remainingDigits.Count; i++)
        //    {
                
        //    }
        //}


        //private bool IsPandigitalProduct(int number, List<int> remainingDigits)
        //{
        //    if (multiplicands.Count < 2)
        //    {
        //        return false;
        //    }

        //    // now I need to see if any of the multiplicands can create the number

        //    List<int> multiplicands;
        //    List<int> multipliers;
        //}

        //private List<int> GetPotentialProducts(List<int> digits, int index)
        //{
        //    int minSize = 3;
        //    int maxSize = 4;

        //    if (digits.Count == maxSize)
        //    {
        //        int number = 0;
        //        for (int i = 0; i < digits.Count; i++)
        //        {
        //            number += digits[digits.Count - i - 1] * 10 ^ i;
        //        }
        //        return new List<int>(number);
        //    }

        //    List<int> combos = new List<int>();
        //    for (int i = index; i < digits.Count; i++)
        //    {
        //        Swap(digits, index, i);
        //        combos.AddRange(GetCombinationsForNumbers(digits, index + 1));
        //        Swap(digits, index, i);

        //    }

        //    return combos;

        //}


        //private List<int> GetCombinationsForNumbers(List<int> digits, int index)
        //{
        //    if (index == digits.Count)
        //    {
        //        int number = 0;
        //        for (int i = 0; i < digits.Count; i++)
        //        {
        //            number += digits[digits.Count - i - 1] * 10 ^ i;
        //        }
        //        return new List<int>(number);
        //    }

        //    List<int> combos = new List<int>();
        //    for (int i = index; i < digits.Count; i++)
        //    {
        //        Swap(digits, index, i);
        //        combos.AddRange(GetCombinationsForNumbers(digits, index + 1));
        //        Swap(digits, index, i);

        //    }

        //    return combos;

        //}

        //private void Swap(List<int> list, int i, int j)
        //{
        //    var indexNum = list[i];
        //    var swapNum = list[j];
        //    list[j] = indexNum;
        //    list[i] = swapNum;

        //}

    }
}
