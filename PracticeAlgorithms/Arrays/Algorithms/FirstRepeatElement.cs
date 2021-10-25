using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //find first repeating element in array that has smallest index
    public class FirstRepeatElement
    {
        public void FirstRepeat(int[] arr)
        {
            //index for first repeating element
            var min = -1;

            //empty hashset
            var hs = new HashSet<int>();

            //traverse arr from last index to first
            //as you want to find the repeated element with smallest index
            for(int i = arr.Length - 1; i >= 0; i++)
            {
                //if element is already is hs, update min
                if (hs.Contains(arr[i]))
                {
                    min = i;
                }
                else //add to hs
                {
                    hs.Add(arr[i]);
                }
            }

            //print results
            if(min != -1)
            {
                Console.WriteLine("First repeating element is " + arr[min]);
            }
            else
            {
                Console.WriteLine("No repeating elements");
            }
        }
    }
}
