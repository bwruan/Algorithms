using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //find max sum of contiguous subarray (aka elements are next to e/o in arr)
    public class LargestSumContiguous
    {
        public int MaxContiguousSubArrSum(int[] arr)
        {
            //initialize for Kadane's Algo
            var maxGlobal = int.MinValue;
            var maxAtIndex = 0;

            //traverse array
            for(int i = 0; i < arr.Length; i++)
            {
                //set max ending at current index = maxAtIndex + element at current index
                maxAtIndex = maxAtIndex + arr[i];

                //if global max is less than index max
                //set global equal to max at index
                if(maxGlobal < maxAtIndex)
                {
                    maxGlobal = maxAtIndex;
                }

                //if max at current index < 0
                //set max at current index to 0
                if(maxAtIndex < 0)
                {
                    maxAtIndex = 0;
                }
            }

            return maxGlobal;
        }
    }
}
