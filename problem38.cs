using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem38
    {
        public long FindMaxPandigitalNumber()
        {
            long currentNum = 100000000 / 9 / 2;
            long currentMax = 0;

            while (currentNum > 0)
            {
                long concatMultiple = currentNum;
                for (int i = 2; i < 9; i++)
                {
                    concatMultiple = ConcatNumbers(concatMultiple, currentNum * i);
                    if (concatMultiple > 987654321)
                    {
                        //too high we done;
                        break;
                    }
                    if (concatMultiple >= 123456789)
                    {
                        Console.WriteLine("i " + i +  " currentNum: " + currentNum);
                        //Sweet spot.  
                        if (IsPandigital(concatMultiple))
                        {
                            if (concatMultiple > currentMax)
                            {
                                currentMax = concatMultiple;
                            }
                            Console.WriteLine("Winner: " +currentNum + ", concat : " + concatMultiple);
//                            return currentNum;
                        }
                    }
                }
                
                currentNum--;
            }

            Console.WriteLine("Max is " + currentMax);
            return currentMax;
        }


        private long ConcatNumbers(params long[] numbers)
        {
            long num0 = numbers[0];
            Stack<long> stackNum = new Stack<long>();
            for (int i = 1; i < numbers.Length; i++)
            {
                long num1 = numbers[i];

                while (num1 > 0)
                {
                    stackNum.Push( num1 % 10);
                    num1 = num1 / 10;
                }

                for (int j = 0; j < stackNum.Count; j++)
                {
                    num0 = num0 * 10;
                    num0 += stackNum.Pop();
                }  

            }

            return num0;
        }



        private bool IsPandigital(long num)
        {
            long maxNum = 9;
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
