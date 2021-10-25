using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //given an array and k, find kth smallest or largest element in array
    public class KthSmallOrLargeElement
    {
        public int KthElement(int[] arr, int k)
        {
            //sort array
            Array.Sort(arr);

            //return the kth element (which would be at index k - 1)
            return arr[k - 1];
        }
    }
}
