using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //arr of n elements, find repeating num in O(n) and O(1) space
    public class FindDuplicates
    {
        public void FindRepeatingNums(int[] arr)
        {
            //traverse through arr
            for(int i = 0; i < arr.Length; i++)
            {
                //take abs value of arr[i] and set that equal to j
                int j = Math.Abs(arr[i]);

                //check if arr[j] is greater than 0 (aka positive)
                //if so, set arr[j] to the negative value of that element
                if(arr[j] >= 0)
                {
                    arr[j] = -arr[j];
                }

                //if arr[j] is a negative element, means element appeared once before
                //log it down as a repeated value
                else
                {
                    Console.Write(j + " ");
                }
            }
        }
    }
}
