using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //given an array (or string) reverse it
    public class ReverseArray
    {
        public void ReverseArr(int[] arr)
        {
            //initialize indexes & temp value
            int start = 0;
            int end = arr.Length - 1;
            int temp;

            //keep looping while start index is less than end index
            //set temp to be the element at arr[start]
            //set arr[start] to be element at arr[end]
            //set arr[end] to the temp value (aka what was arr[start])
            while(start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }

            //loop through array and print the array
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
