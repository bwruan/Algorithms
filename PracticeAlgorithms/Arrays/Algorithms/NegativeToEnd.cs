using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //unsorted arr with + and - int, move all - elements to end of arr without changing order
    public class NegativeToEnd
    {
        public void MoveNegativeToEnd(int[] arr)
        {
            //create temp Arr
            var temp = new int[arr.Length];

            //index of temp Arr
            int j = 0;

            //traverse arr and store all + elements to temp arr
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] >= 0)
                {
                    temp[j++] = arr[i];
                }
            }

            //if arr is all + or if arr is all -
            if(j == arr.Length || j == 0)
            {
                return;
            }

            //store - elements into temp
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    temp[j++] = arr[i];
                }
            }

            //copy temp[] to arr[]
            for(int i = 0; i< arr.Length; i++)
            {
                arr[i] = temp[i];
            }
        }
    }
}
