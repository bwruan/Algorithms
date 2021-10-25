using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //given array of random order of 0s, 1s, and 2s, sort it in order of 0s, 1s, 2s.
    public class SortArr012
    {
        public void SortArr(int[] arr)
        {
            //initialize count 0s, 1s, 2s
            int c0 = 0;
            int c1 = 0;
            int c2 = 0;
            int i;

            //traverse array and increase count of 0, 1, 2, respectively
            for(i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 0:
                        c0++;
                        break;
                    case 1:
                        c1++;
                        break;
                    case 2:
                        c2++;
                        break;
                }
            }

            //reset i to 0
            i = 0;

            //traverse array and replace with 0s first, then 1s, then 2
            while(c0 > 0)
            {
                arr[i++] = 0;
                c0--;
            }

            while(c1 > 0)
            {
                arr[i++] = 1;
                c1--;
            }

            while(c2 > 0)
            {
                arr[i++] = 2;
                c2--;
            }

            //print sorted array
            for(i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
