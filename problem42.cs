using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem42
    {
        private int Count { get; set; }
        private List<bool> TriangleNumbers { get; set; }
        private int LastTriangleNumber = 0;

        public Problem42()
        {
            TriangleNumbers = new List<bool>();
            LastTriangleNumber = 0;
        }

        public int CountTriangleNumbers(string fileName)
        {
            Count = 0;
            
            var fileText = ReadFile(fileName);
            fileText = fileText.Replace("\"", "");

            var words = fileText.Split(',');

            for (int i = 0; i < words.Length; i++)
            {
                if (CheckTriangleWord(words[i]))
                {
                    Count++;
                }
            }

            return Count;
        }

        private string ReadFile(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        private bool CheckTriangleWord(string word)
        {
            var number = GetNumberForWord(word);

            while (TriangleNumbers.Count <= number)
            {
                GetTriangleNumbers();
            }
            return TriangleNumbers[number];
        }

        private void GetTriangleNumbers()
        {
            var nextTriangleNumber = LastTriangleNumber * (LastTriangleNumber + 1) / 2;
            LastTriangleNumber++;
            for (int i = TriangleNumbers.Count; i < nextTriangleNumber; i++)
            {
                TriangleNumbers.Add(false);
            }

            //Console.WriteLine("next triangle number: " + nextTriangleNumber + ".  Count of triangle numbers " + TriangleNumbers.Count);
            TriangleNumbers.Add(true);

            //Console.WriteLine("TriangleNumber : " + nextTriangleNumber + ": " + TriangleNumbers[nextTriangleNumber]);
        }

        private int GetNumberForWord(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                count += (int)word[i] - 64;
            }
//            if (count < 30)
//            {
 //               Console.WriteLine("Count for word:" + word + ":  " + count);
  ///          }
            return count;
        }

    }
}
