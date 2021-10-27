using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //find max product of continuous subarr
    public class SubArrMaxProduct
    {
        //utility function to get min of 2 int
        public int Min(int x, int y)
        {
            //if x < y, return x else y
            return x < y ? x : y;
        }

        //utility function to get max of 2 int
        public int Max(int x, int y)
        {
            //if x > y return x, else y
            return x > y ? x : y;
        }

        public int MaxProduuct(int[] arr)
        {
            //overall product
            var result = 0;
            var count = 0;

            //max + product at current position
            var max_here = 1;

            //min - product at current position
            var min_here = 1;

            //traverse through array
            //max_here always 1 or + product ending with arr[i]
            //min_here always 1 or - product ending with arr[i]
            for(int i = 0; i < arr.Length; i++)
            {
                //if element is +
                //update max_here 
                //update min_here if min is negative
                if(arr[i] > 0)
                {
                    max_here = max_here * arr[i];
                    min_here = Min(min_here * arr[i], 1);
                    count = 1;
                }

                //if element is 0, keep max and min here at 1
                if(arr[i] == 0)
                {
                    max_here = 1;
                    min_here = 1;
                }

                //if element is -
                //max_here can be 1 or +; will be 1 if prior min_here is 1 else will be prev min_here * arr[i]
                //min_here can be 1 or -; will always be max_here * arr[i]
                if(arr[i] < 0)
                {
                    int temp = max_here;
                    max_here = Max(min_here * arr[i], 1);
                    min_here = temp * arr[i];
                }

                if(result < max_here)
                {
                    result = max_here;
                }
            }

            if(count == 0 && result == 0)
            {
                return 0;
            }

            return result;
        }
    }
}
