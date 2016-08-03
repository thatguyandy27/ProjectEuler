using System;

namespace ProjectEuler{

    public class Problem63
    {
        public int GetTotal(){
            int max = 50,
                count = 0;

            for (int i = 1; i <= max; i++)
            {
                count += GetCountForPower(i);
                Console.WriteLine("{0}: {1}", i, count);
            }


            return count;

        }

        public int GetCountForPower(int pow){
            double max = Math.Pow(10, pow),
                currentValue = 0,
                min = Math.Pow(10, pow -1);

            int count = 0,
                index = 1;
            
            while(currentValue < max){
                currentValue = Math.Pow(index, pow); 
                if (currentValue >= min && currentValue < max){
                    count++;
                }
                index+=1;
            }
            

            return count;

        }
    }
}