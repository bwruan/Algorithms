using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //given array, print element and their freq
    public class FreqOfArrElements
    {
        public void CountFreq(int[] arr)
        {
            //dictionary to store key (int in the arr) and value (occurance of int)
            var map = new Dictionary<int, int>();

            //if the dictionary does not have the element, add it in and set value to one
            //otherwise add 1 to the value if it is already in the dictionary
            foreach (var i in arr)
            {
                if (!map.ContainsKey(i))
                {
                    map.Add(i, 1);
                }
                else
                {
                    map[i] += 1;
                }
            }

            //loop through dictionary & print out key and value
            foreach (var m in map)
            {
                Console.WriteLine(m.Key + ", " + m.Value);
            }
        }
    }
}
