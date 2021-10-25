using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //Find an element that is NOT smaller than its neighbors
    public class PeakElement
    {
        public int SearchForPeak(int[] arr, int low, int high)
        {
            //initialize middle index
            int mid = (low + high) / 2;

            //check if middle element is peak element by comparing with neighbors
            if (arr[mid] >= arr[mid + 1] || arr[mid] >= arr[mid - 1])
            {
                return mid;
            }

            //left neighbor is larger -> find peak in left half of arr
            else if (arr[mid - 1] > arr[mid])
            {
                return SearchForPeak(arr, low, (mid - 1));
            }

            //right neighbor is larger -> find peak in right half of arr
            else
            {
                return SearchForPeak(arr, (mid + 1), high);
            }
        }
        
        public int FindPeakElement(int[] arr)
        {
            return SearchForPeak(arr, 0, arr.Length - 1);
        }
    }
}
