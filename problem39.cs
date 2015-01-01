using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem39
    {
       
        public Problem39()
        {
        }

        public int FindMaxSolutions(int maxVal)
        {
            var currentMax = 0;
            var currentSolution = 0;
            var index = 4;


            while (index <= maxVal)
            {
                currentSolution = FindMaxSolutionsForNumber(index);

                if (currentSolution > currentMax)
                {
                    Console.WriteLine("Current Leader: " + index + ". With " + currentSolution);
                    currentMax = currentSolution;
                }
                index++;
            }


            return currentMax;

        }

        private int FindMaxSolutionsForNumber(int num)
        {
            int a = 1,
                b = 1,
                c = num - a - b,
                solutionCount = 0;

            if (num == 120)
            {
                var d = 0;
            }

            while (c > a)
            {
                b = a;
                c = num - a - b;
                
                while (c > b)
                {
                    c = num - a - b;
                    var cResult = Math.Sqrt(a * a + b * b);
                    if (cResult == c)
                    {
                        solutionCount++;
                    }

                    b++;
                }

                a++;

            }

            //if (num == 120)
            //{
            //    var c = 0;
            //}

            //for (var a = 1; a < maxVal; a++)
            //{
            //    for (var b = 1; b < maxVal - a; b++)
            //    {
            //        var c = num - a - b;
            //    }
            //}

            return solutionCount;
        }
    }
}
