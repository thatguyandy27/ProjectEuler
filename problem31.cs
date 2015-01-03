using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem31
    {

        public int CountPossibleSolutions(int max, int[] coinValues)
        {
            return CountSolutions(max, coinValues.Reverse().ToArray(), 0, 0);
        }


        private int CountSolutions(int max, int[] coinValues, int currentIndex, int currentSum)
        {
            if (currentSum == max)
            {
                return 1;
            }
            else if (currentSum > max)
            {
                return 0;
            }

            int solutions = 0;

            for (int index = currentIndex; index < coinValues.Length; index++)
            {
                var difference = max - currentSum;
                int currentCoin = coinValues[index];
                var numberOfCombinations = difference / currentCoin;

                for (int i = 0; i < numberOfCombinations; i++)
                {
                    currentSum += currentCoin;
                    solutions += CountSolutions(max, coinValues, index+1, currentSum);
                }
                currentSum -= (numberOfCombinations * currentCoin);

                //int currentCoin = coinValues[index];
                //currentSum += currentCoin;

                //solutions += CountSolutions(max, coinValues, index, currentSum);
                //currentSum -= currentSum;
            }

            return solutions;
        }
    }
}
