using System;
using System.Numerics;

namespace ProjectEuler{

    public class Problem97{

        public void FindPrime(){
            BigInteger bigInt1 = new BigInteger(28433);
            var pow =  BigInteger.ModPow(2, 7830457, 10000000000) ;

            Console.WriteLine(pow);
            var bigInt2 = BigInteger.Multiply(bigInt1,  pow) + 1;

            Console.WriteLine(bigInt2 % 10000000000);
            
        }
    }
}