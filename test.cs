using System;

namespace Playground{

    public static class Sandbox{
        
        public static void PrintPermutations(char[] str, int index){
            if (index == str.Length){
                Console.WriteLine(new String(str));
            }
            
            for(int i = index; i < str.Length; i++){
                Swap(str, index, i);
                PrintPermutations(str, index + 1);
                Swap(str, index, i);
            }
        }

        private static void Swap(char[] str, int index1, int index2){
            char temp = str[index1];
            str[index1] = str[index2];
            str[index2] = temp;
        }
    }
}