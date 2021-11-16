using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //n non-neg int = elevation map width of each bar is 1
    //compute how much water it is able to trap after raining
    public class RainWater
    {
        //extra space
        public int FindWater(int[] arr)
        {
            //create left and right arr of same size as arr
            //each contain heights of tallest bar to left/right of i'th bar + itself
            var left = new int[arr.Length];
            var right = new int[arr.Length];

            //initialize results
            var water = 0;

            //add to left and right arr greater of two values at
            //at arr[i] vs left[i - 1]/right[i + 1]
            left[0] = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                left[i] = Math.Max(left[i - 1], arr[i]);
            }

            right[arr.Length - 1] = arr[arr.Length - 1];
            for(int i = arr.Length - 2; i >= 0; i--)
            {
                right[i] = Math.Max(right[i + 1], arr[i]);
            }

            //calculate acumulated water element by element
            for(int i = 0; i < arr.Length; i++)
            {
                water += Math.Min(left[i], right[i]) - arr[i];
            }

            return water;
        }

        //O(1) space
        public int FindMaxWater(int[] arr)
        {
            //initialize output
            var water = 0;

            //max element on left and right
            var leftMax = 0;
            var rightMax = 0;

            //index to traverse the array
            var lo = 0;
            var hi = arr.Length - 1;

            while(lo <= hi)
            {
                if(arr[lo] < arr[hi])
                {
                    if (arr[lo] > leftMax)
                    {
                        leftMax = arr[lo];
                    }
                    else
                    {
                        water += leftMax - arr[lo];
                        lo++;
                    }
                }
                else
                {
                    if(arr[hi] > rightMax)
                    {
                        rightMax = arr[hi];
                    }
                    else
                    {
                        water += rightMax - arr[hi];
                        hi--;
                    }
                }
            }

            return water;
        }
    }
}
