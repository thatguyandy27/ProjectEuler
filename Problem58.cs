using System;
using System.Collections.Generic;

namespace ProjectEuler{

    public class Problem58{

        public int FindLength(){
            List<List<int>> grid = new List<List<int>>();
            grid.Add(new List<int>());
            grid[0].Add(1);

            decimal primes = 0,
                cornerCount = 1;

            do {
                AddSquareToGrid(grid);
                
                primes += GetPrimeCount(grid);
                cornerCount += 4;
                Console.WriteLine(primes / cornerCount * 100);
             }while(primes / cornerCount * 100 > 10);

        
            return grid.Count;
        }

        public int GetPrimeCount(List<List<int>> grid){
            int count = 0,
                length = grid.Count;
            // check top left
            if (this.IsPrime(grid[0][0])){
                count++;
            }

            // check top right
            if (this.IsPrime(grid[length - 1][0])){
                count++;
            }

            // check bottom right
            if (this.IsPrime(grid[length - 1][length - 1])){
                count++;
            }

            // check bottom left
            if (this.IsPrime(grid[0][length - 1])){
                count++;
            }

            return count;
        }
 
        public void AddSquareToGrid(List<List<int>> grid){
            int length = grid.Count, 
                lastNumber = grid[length - 1][length -1]; 
            // add colum to the right
            grid.Add(new List<int>());
            // add colum to the left
            grid.Insert(0, new List<int>());

            length += 2;

            // start at bottom right and work back up to top row
            for(int y = length - 2; y >= 0; y--){
                // Console.WriteLine("{0},{1}", length - 1, 0);
                lastNumber += 1;
                grid[length - 1].Insert(0, lastNumber);
            }

            // top row backwards minus the last on right
            for (int x = length - 2; x >= 0; x--){
                // Console.WriteLine("{0},{1}",x, 0);
                lastNumber += 1;
                grid[x].Insert(0, lastNumber);
            }
            
            // for top left + 1 to the bottom left
            for (int y = 1; y < length; y++){
                // Console.WriteLine("{0},{1}", 0, y);
                lastNumber += 1;
                grid[0].Add(lastNumber);
            }

            // bottom left + 1 to bottom right
            for (int x = 1; x < length; x++){
                // Console.WriteLine("{0},{1}", x, length - 1);

                lastNumber += 1;
                grid[x].Add(lastNumber);
            }
        }

        public bool IsPrime(int n){
            
            // if (number % 2 == 0){
            //     return false;
            // }
            // int i = 3,
            //     result = number /i;

            // if (number % i == 0) {
            //     return false;
            // }
            // do{
            //     i += 2;
            //     result = number / i;
                
            //     if (number % i == 0) {
            //         return false;
            //     }

            // } while(i < result);

            // return true;
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            if (n < 9) return true;
            if (n % 3 == 0) return false;
            
            long counter = 5;            
            while ((counter * counter) <= n) {
                if (n % counter == 0) return false;
                if (n % (counter + 2) == 0) return false;
                counter += 6;
            }

            return true;

        }
    }
}