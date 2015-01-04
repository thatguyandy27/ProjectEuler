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

            var prob32 = new Problem32();

            var results = prob32.GetPandigitalProducts();

            var sum = results.Sum();

            Console.WriteLine(sum);

            //var prob31 = new Problem31();

            //var count= prob31.CountPossibleSolutions(200, new int[]{200,100,50,20,10,5,2,1});

            //Console.WriteLine(count);
            //var prob33 = new Problem33();
            //var result = prob33.FindNonTrivialFractions();



            //var prob39 = new Problem39();
            //var result = prob39.FindMaxSolutions(1000);

            //Console.WriteLine("final result: " + result);

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

            //var prob37 = new Problem37();

            //var results = prob37.GetTruncatablePrimes();

            //long sum = 0;
            //for (int i = 0; i < results.Length; i++)
            //{
            //    sum += results[i];
            //}

            //Console.WriteLine("SUM is " + sum);
//            Console.WriteLine((int)'A');
            Console.ReadLine();
        }
    }
}
