using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem44
    {
        // store the index & the value
        private HashSet<long> _pentognalNumbers = new HashSet<long>();
        private List<long> _pentognalByIndex = new List<long>();

        private long _solution = 0;

        public void FindPair()
        {
            int index = 0;
            bool isFound = false;
            long currentValue = 0;

            _solution = 0;

            // while not found
            while (!isFound)
            {
                // see if it is in the list already
                if (_pentognalByIndex.Count <= index)
                {
                    //generate it if it isn't
                    currentValue = GeneratePentognalNumber(index);
                }
                else
                {
                    currentValue = _pentognalByIndex[index];
                }

                isFound = PairFound(index);

                index++;
            }
            
        }

        public bool PairFound(int index)
        {
            var currentValue = this._pentognalByIndex[index];
            var maxValue = this._pentognalByIndex[_pentognalByIndex.Count - 1];

            long indexValue = 0;
            // loop through. see if the subtraction of them is equal to another
            for (int i = 1; i < index; i++)
            {
                indexValue = this._pentognalByIndex[i];
                long difference = currentValue - indexValue;

                if (_pentognalNumbers.Contains(difference))
                {
                    // OMG DIFFERENCE IS THERE
                    // CHECK FOR SUM

                    var sum = currentValue + indexValue;

                    while (sum >= maxValue)
                    {
                        GeneratePentognalNumber(_pentognalByIndex.Count);
                        maxValue = this._pentognalByIndex[_pentognalByIndex.Count - 1];
                    }


                    if (_pentognalNumbers.Contains(sum))
                    {
                        // contains sum too WE FOUND IT!

                        Console.WriteLine(string.Format("n1: {0}.  n2: {1}.  difference: {2}", index, i, difference));
                        return true;
                    }

                }
                
            }

            return false;
        }


        private long GeneratePentognalNumber(long index)
        {
            var result =  index * (3 * index - 1) / 2;
            _pentognalNumbers.Add(result);
            _pentognalByIndex.Add(result);

            return result;
        }


    }
}
