using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //rotate arr clockwise by one
    public class RotateArrByOne
    {
        public void RotateArr(int[] arr)
        {
            //store last element into var x
            var x = arr[arr.Length - 1];

            //loop through arr backwards, moving elements to the right
            //set element at index 0 to be equal to x
            for(int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
                arr[0] = x;
            }
        }
    }
}
