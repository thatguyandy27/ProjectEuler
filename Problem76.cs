using System;

namespace ProjectEuler{

    public class Problem76{

        public int FindSolution(){
            int target = 100;
            int[] ways = new int[target + 1];
            ways[0] = 1;
            
            for (int i = 1; i <= 99; i++) {
                for (int j = i; j <= target; j++) {
                    ways[j] += ways[j - i];
                }
            }

            return ways[target];
        }
        
    }
}