using System;

namespace ProjectEuler{
    public class Problem206{

        public long FindConcealedSquare(){
            long min = 1020304050607080900,
                max = 1929394959697989990;

            var lowerNum = Math.Floor(Math.Sqrt(min));
            bool found = false;
            var nextNum = Convert.ToInt64(lowerNum);

            while(!found){

                var square = Convert.ToInt64(nextNum*nextNum);
                // Console.WriteLine("{0} -> {1}", nextNum, square);
                if (IsMatch(square)){
                    return nextNum;
                }
                nextNum += 10;

            }
            

            

           return 0;
            
        }

        private bool IsMatch(long num){
            int index = 9;

            if (num % 10 != 0){
                return false;
            }
            
            num /= 100;
            while (index > 0){
                if (num % 10 != index){
                    return false;
                }

                index--;
                num /= 100;
            }

            return true;
        }
    }
}