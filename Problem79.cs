using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler{

    public class Problem79{

        public string GetPasscode(){
            List<int> orderedList = new List<int>(){0,1,2,3,4,5,6,7,8,9};
            bool[] used = new bool[]{false, false, false, false,false, false,false, false, false, false};

            for(int i = 0; i < passcodes.Length; i++){
                var passcode = passcodes[i];
                
                // ok got rid of unused numbers
                for(int c = 0; c < passcode.Length; c++){
                    used[passcode[c]] = true;
                }

            }

            orderedList.RemoveAll(i => !used[i]);

            Dictionary<int, List<int>> numbersBefore = new Dictionary<int, List<int>>();

            foreach (var item in orderedList){
                List<int> numbers = new List<int>();
                numbersBefore.Add(item, numbers);
                for(int i = 0; i < passcodes.Length; i++){
                    var passcode = passcodes[i];
                    for(int c = 0; c < passcode.Length; c++){
                        if(passcode[c] == item){
                            for(int c2 = c -1; c2 >= 0; c2--){
                                numbers.Add(passcode[c2]);
                            }
                        }
                    }
                }
            }

            var orderdResult = numbersBefore.OrderBy(x => x, Comparer<KeyValuePair<int, List<int>>>.Create((x,y) => {
               if (x.Value.Contains(y.Key)){ //  y comes before x
                   return 1;
               }
               else if(y.Value.Contains(x.Key)){// x comes before y
                    return -1;
               } 
               else{
                   return x.Value.Count.CompareTo(y.Value.Count);
               }
            }));
            

            return string.Join("", orderdResult.Select(i => i.Key.ToString()));
        }


        public int[][] passcodes = new int[][]{
            new int[]{3,1,9},
            new int[]{6,8,0},
            new int[]{1,8,0},
            new int[]{6,9,0},
            new int[]{1,2,9},
            new int[]{6,2,0},
            new int[]{7,6,2},
            new int[]{6,8,9},
            new int[]{7,6,2},
            new int[]{3,1,8},
            new int[]{3,6,8},
            new int[]{7,1,0},
            new int[]{7,2,0},
            new int[]{7,1,0},
            new int[]{6,2,9},
            new int[]{1,6,8},
            new int[]{1,6,0},
            new int[]{6,8,9},
            new int[]{7,1,6},
            new int[]{7,3,1},
            new int[]{7,3,6},
            new int[]{7,2,9},
            new int[]{3,1,6},
            new int[]{7,2,9},
            new int[]{7,2,9},
            new int[]{7,1,0},
            new int[]{7,6,9},
            new int[]{2,9,0},
            new int[]{7,1,9},
            new int[]{6,8,0},
            new int[]{3,1,8},
            new int[]{3,8,9},
            new int[]{1,6,2},
            new int[]{2,8,9},
            new int[]{1,6,2},
            new int[]{7,1,8},
            new int[]{7,2,9},
            new int[]{3,1,9},
            new int[]{7,9,0},
            new int[]{6,8,0},
            new int[]{8,9,0},
            new int[]{3,6,2},
            new int[]{3,1,9},
            new int[]{7,6,0},
            new int[]{3,1,6},
            new int[]{7,2,9},
            new int[]{3,8,0},
            new int[]{3,1,9},
            new int[]{7,2,8},
            new int[]{7,1,6}
        };
    }
    
}