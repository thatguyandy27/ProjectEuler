﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //var problem41 = new Problem41();

            //var result = problem41.FindLargestPandigitalPrime();

            //Console.WriteLine(result);

            //var problem38 = new Problem38();
            //problem38.FindMaxPandigitalNumber();
            // var problem55 = new Problem55();
            // var result = problem55.FindLychrelNumbers(10000, 50);
            // foreach (var ans in result)
            // {
            //     Console.WriteLine(ans);
            // }
            
            // Console.WriteLine("Here is the result: {0}", result.Count);
            
            // var problem57 = new Problem57();

            // Console.WriteLine(problem57.GetFractionsWithMoreDigitsInNumerator2());

            // var problem58 = new Problem58();
            // Console.WriteLine("Answer is {0}", problem58.FindLength());

            // var problem59 = new Problem59();
            // problem59.GenerateFiles();
            // Console.WriteLine(problem59.GetASCIISum(new int[]{'g','o', 'd'}));

            // var problem63 = new Problem63();

            // Console.WriteLine(problem63.GetTotal());

            // var problem51 = new Problem51();
            // problem51.BruteForce();

            // var problem92 = new Problem92();
            // Console.WriteLine("Solution: {0}", problem92.GetCount());

            // var problem97 = new Problem97();

            // problem97.FindPrime();

            // var p206 = new Problem206();
            // Console.WriteLine(p206.FindConcealedSquare());

            // var p79 = new Problem79();
            // Console.WriteLine(p79.GetPasscode());

            // var p71 = new Problem71();
            // Console.WriteLine(p71.FindNumerator());

            // var p76 = new Problem76();

            // Console.WriteLine(p76.FindSolution());

            // var problem52 = new Problem52();
            // Console.WriteLine(problem52.FindSmallestPermutedMultiple());

            //var prob32 = new Problem32();

            //var results = prob32.GetPandigitalProducts();

            //var sum = results.Sum();

            //Console.WriteLine(sum);

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

            // Sandbox.PrintPermutations("ABCD".ToCharArray(), 0);
            CoinCombos combos = new CoinCombos();
            for(int i =10; i <= 10; i++){
                 Console.WriteLine("The # of combos for {0} is {1}", i, combos.FindCombinations(new int[]{25,10,5,1}, i));
            }
            // Console.WriteLine("The # of combos for {0} is {1}", 9, combos.FindCombinations(new int[]{25,10,5,1}, 9));
            //Console.WriteLine("SUM is " + sum);
//            Console.WriteLine((int)'A');
            Console.ReadLine();
        }
    }
}
