using System;
using System.Collections.Generic;

namespace Playground{

    public class CoinCombos{

        public int FindCombinations(int[] coins, int total){
            return FindCombo(coins, 0, new Dictionary<int,int>(), total);
        }

        public int FindCombo(int[] coins, int coinIndex, Dictionary<int,int> comboCache, int totalAmount){
            int count = 0;
            Console.WriteLine("coinIndex: {0}, totalAmount: {1}", coinIndex, totalAmount);
              
            if (totalAmount == 0){
                Console.WriteLine("return 1 => {0}", totalAmount);
                return 1;
            }
            else if (totalAmount < 0){
                Console.WriteLine("return 0 => {0}", totalAmount);
                return 0;
            }

            // if (comboCache.ContainsKey(totalAmount)){
            //     Console.WriteLine("{0} => {1}", totalAmount, comboCache[totalAmount]);
            //     return comboCache[totalAmount];
            // }

            for(int i = coinIndex; i < coins.Length; i++){
                count += FindCombo(coins, i, comboCache, totalAmount - coins[i]);
            }
            
            // comboCache.Add(totalAmount, count);

            return count;
        }
    }
}