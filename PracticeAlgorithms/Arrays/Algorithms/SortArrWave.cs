using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //unsorted arr, sort into wave like arr
    //arr[0] >= arr[1] <= arr[2]....
    public class SortArrWave
    {
        //method to swap 2 ints
        public void Swap(int[] arr, int a, int b)
        {
            var temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        public void WaveSortedArr(int[] arr)
        {
            //traverse even index of arr
            for(int i = 0; i < arr.Length; i+= 2)
            {
                //current element < prev element
                if(i > 0 && arr[i-1] > arr[i])
                {
                    Swap(arr, i - 1, i);
                }

                //current element < next element
                if(i < arr.Length && arr[i] < arr[i + 1])
                {
                    Swap(arr, i, i + 1);
                }
            }
        }
    }
}
