using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem52
    {

        public int FindSmallestPermutedMultiple()
        {
            int num = 5;

            while (num > 0)
            {
                if (ArePermutations(num * 2, num * 3, num * 4, num * 5, num * 6))
                {
                    Console.WriteLine("FOUND " + num);
                    return num;
                }

                num++;
            }

            return 0;
        }

        public bool ArePermutations(int num1, int num2, int num3, int num4, int num5)
        {
            var str1 = num1.ToString();
            var str2 = num2.ToString();
            var str3 = num3.ToString();
            var str4 = num4.ToString();
            var str5 = num5.ToString();
            Dictionary<int, int>[] numCount = new Dictionary<int, int>[]{
                new Dictionary<int, int>(),
                new Dictionary<int, int>(),
                new Dictionary<int, int>(),
                new Dictionary<int, int>(),            
                new Dictionary<int, int>(),            
            };
           
            if (str1.Length != str2.Length && str1.Length != str3.Length && str1.Length != str4.Length
                && str1.Length != str5.Length )
            {
                return false;
            }


            while (num1 > 0 && num2 > 0 && num3 > 0 && num4 > 0 && num5 > 0)
            {
                numCount[0].AddNumber(num1 % 10);
                numCount[1].AddNumber(num2 % 10);
                numCount[2].AddNumber(num3 % 10);
                numCount[3].AddNumber(num4 % 10);
                numCount[4].AddNumber(num5 % 10);

                num1 = num1 / 10;
                num2 = num2 / 10;
                num3 = num3 / 10;
                num4 = num4 / 10;
                num5 = num5 / 10;
            }

            foreach (var key in numCount[0].Keys)
            {
                if (!numCount[1].ContainsKey(key) ||
                    !numCount[2].ContainsKey(key) ||
                    !numCount[3].ContainsKey(key) ||
                    !numCount[4].ContainsKey(key))
                {
                    return false;
                }

                if (numCount[0][key] != numCount[1][key] ||
                     numCount[0][key] != numCount[2][key] ||
                     numCount[0][key] != numCount[3][key] ||
                     numCount[0][key] != numCount[4][key] )
                {
                    return false;
                }

            }

            return true;

        }

        
    }

    public static class MyExtensions
    {
        public static void AddNumber(this Dictionary<int, int> numCount, int num)
        {
            if (!numCount.ContainsKey(num))
            {
                numCount.Add(num, 0);
            }

            numCount[num] += 1;

        }
    }   
}
