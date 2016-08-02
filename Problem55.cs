using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public class Problem55
    {
        public int MaxCount { get; set; }
        private Dictionary<ulong, bool> testedNumbers;
        
        public List<ulong> FindLychrelNumbers(int maxNum, int maxCount){
            this.testedNumbers = new Dictionary<ulong, bool>();
            this.MaxCount = maxCount;
            
            for (ulong i = (ulong)maxNum; i > 0; i--)
            {
                isNumberLychrel(i, 0);
            }

            return this.testedNumbers.Where( x => !x.Value).Select(x => x.Key).ToList();
        }

        private bool isNumberLychrel(ulong num, int depth){
            // if max then false
            if (depth >= this.MaxCount){
                return false;
            }
            // check to see if the key already exists 
            if(this.testedNumbers.ContainsKey(num)){
                return this.testedNumbers[num];
            }
            // get the reverse value
            var reverse = getReverse(num);

            var sum = num + reverse;

            var isLychrel = isPalindrome(sum) || isNumberLychrel(sum, depth + 1);

            // this.testedNumbers[reverse] = isLychrel;
            if (num < 10000){
                this.testedNumbers[num] = isLychrel;
            }
            return isLychrel;
        }

        private bool isPalindrome(ulong num){
            List<ulong> digits = new List<ulong>();
            bool isPalindrome = true;

            while(num > 0){
                digits.Add(num % 10);
                num /= 10;
            }

            for(int i = 0; i < digits.Count / 2; i++ )
            {
                if (digits[i] != digits[digits.Count - i - 1]){
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;

        }

        private ulong getReverse(ulong num){
            List<ulong> nums = new List<ulong>();
            
            while (num > 0){
                nums.Add(num % 10 );

                num = num / 10;
            }

            ulong newNum = 0;

            for (int i = 0; i < nums.Count; i++){
                newNum += nums[nums.Count - i - 1] *  (ulong)Math.Pow(10, i);
            }            
            return newNum;
        }
    }

}