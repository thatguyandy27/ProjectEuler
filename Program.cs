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
            /*
            var prob45 = new problem45()
            {
                StartNumberHex = 143,
                StartNumberPent = 165,
                StartNumberTri = 285
            };


            Console.Write(prob45.GetNextNumber());
            */

           // var prob44 = new Problem44();

           // prob44.FindPair();

            //var prob42 = new Problem42();
            //Console.WriteLine(prob42.CountTriangleNumbers("C:\\Users\\andyd_000\\Documents\\GitHub\\ProjectEuler\\p042_words.txt"));

            var prob37 = new Problem37();

            var results = prob37.GetTruncatablePrimes();

            long sum = 0;
            for (int i = 0; i < results.Length; i++)
            {
                sum += results[i];
            }

            Console.WriteLine("SUM is " + sum);
//            Console.WriteLine((int)'A');
            Console.ReadLine();
        }
    }
}
