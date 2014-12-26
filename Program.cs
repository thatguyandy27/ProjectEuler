using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {

            var prob45 = new problem45()
            {
                StartNumberHex = 143,
                StartNumberPent = 165,
                StartNumberTri = 285
            };


            Console.Write(prob45.GetNextNumber());

            Console.ReadLine();
        }
    }
}
