using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //Returns the maximum and minimum element is an array making minimum # of comparison
    public class MaxMinOfArrMinComparisons
    {
        //initialize class - used to return 2 values
        public class Pair
        {
            public int Min;
            public int Max;
        }

        public Pair GetMinMax(int[] arr)
        {
            var minMax = new Pair();
            int i = 0;

            //if arr.Length is even, set first two elements as min and max
            if(arr.Length % 2 == 0)
            {
                if (arr[0] > arr[1])
                {
                    minMax.Max = arr[0];
                    minMax.Min = arr[1];
                }
                else
                {
                    minMax.Max = arr[1];
                    minMax.Min = arr[0];
                }

                i = 2;
            }
            //if arr.Length is odd, set first element as Min and Max
            else
            {
                minMax.Max = arr[0];
                minMax.Min = arr[0];

                i = 1;
            }

            //loop and choose elements in pairs and compare with current min and max
            while(i < arr.Length - 1)
            {
                if(arr[i] > arr[i + 1])
                {
                    if (arr[i] > minMax.Max)
                    {
                        minMax.Max = arr[i];
                    }
                    if (arr[i + 1] < minMax.Min)
                    {
                        minMax.Min = arr[i + 1];
                    }
                }
                else
                {
                    if (arr[i + 1] > minMax.Max)
                    {
                        minMax.Max = arr[i + 1];
                    }
                    if (arr[i] < minMax.Min)
                    {
                        minMax.Min = arr[i];
                    }
                }

                i += 2;
            }

            return minMax;
        }
    }
}
