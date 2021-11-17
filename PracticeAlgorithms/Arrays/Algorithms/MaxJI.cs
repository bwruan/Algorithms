using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //arr[], find max j - i so arr[j] > arr[i]
    public class MaxJI
    {
        public int MaxIndexDiff(int[] arr)
        {
            var i = 0;
            var j = 0;

            //2 arr to store max going R -> L
            //and min value going L -> R
            var RMax = new int[arr.Length];
            var LMin = new int[arr.Length];

            //loop through and store smaller of the two num
            LMin[0] = arr[0];
            for(i = 1; i < arr.Length; i++)
            {
                LMin[i] = Math.Min(arr[i], LMin[i - 1]);
            }

            //loop through and store bigger of two num
            RMax[arr.Length - 1] = arr[arr.Length - 1];
            for(j = arr.Length - 2; j>= 0; --j)
            {
                RMax[j] = Math.Max(arr[j], RMax[j + 1]);
            }

            //set i and j back to 0
            //initialize result
            i = 0;
            j = 0;
            var maxDiff = -1;

            //traverse through both left and right arr to find max j-i
            while(j < arr.Length && i < arr.Length)
            {
                if(LMin[i] <= RMax[j])
                {
                    maxDiff = Math.Max(maxDiff, j - i);
                    j = j + 1;
                }
                else
                {
                    i = i + 1;
                }
            }

            return maxDiff;
        }
    }
}
