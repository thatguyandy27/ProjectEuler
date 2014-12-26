using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class problem45
    {
        public long StartNumberHex { get; set; }
        public long StartNumberPent { get; set; }
        public long StartNumberTri { get; set; }


        public long GetNextNumber()
        {
            var nextPentagonalNumber = GetNextPentagonalNumber();
            var nextHexognalNumber = GetNextTriangleNumber();
            var nextTriangleNumber = GetNextHexagonalNumber();

            while (nextPentagonalNumber != nextHexognalNumber || nextHexognalNumber != nextTriangleNumber)
            {
                /// if nextHexognalNumber number is biger then the pent 
                /// then pent must get increased
                if (nextHexognalNumber > nextPentagonalNumber)
                {
                    nextPentagonalNumber = GetNextPentagonalNumber();
                }
                    // if the pentagonal number is greater than the triangle then increase it
                else if (nextPentagonalNumber > nextTriangleNumber)
                {
                    nextTriangleNumber = GetNextTriangleNumber();
                }
                    // if they were all equal thne it should exit
                else
                {
                    nextHexognalNumber = GetNextHexagonalNumber();
                }
            }


            return nextPentagonalNumber;


        }

        private long GetNextHexagonalNumber()
        {
            StartNumberHex++;
            var result = StartNumberHex * (2 * StartNumberHex - 1);
            return result;
        }

        private long GetNextPentagonalNumber()
        {
            StartNumberPent++;
            var result = StartNumberPent * (3 * StartNumberPent - 1) / 2;
            return result;
        }

        private long GetNextTriangleNumber()
        {
            StartNumberTri++;
            var result = StartNumberTri * (StartNumberTri + 1) / 2;
            return result;
 
        }
    }
}
