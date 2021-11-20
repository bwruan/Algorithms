using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    /*Arr of n int, each value represents # of choco in packet each packet has variable # of choco
     m students, task is to distribute choco so that
     each student gets 1 packet and 
     find minimum difference b/w max choco and min choco packet given to students*/
    class ChocolateDistribution
    {
        public int FindMinDiffChocoPack(int[] arr, int m)
        {
            //no choco packs or students
            if(m == 0 || arr.Length == 0)
            {
                return 0;
            }

            //arr.length cannot be less than # of students
            if(arr.Length < m)
            {
                return -1;
            }

            //sort arr
            Array.Sort(arr);

            //initialize results to be largest number possible
            var minDiff = int.MaxValue;

            //find subarr of size m so that diff b/w first and last index (sorted) is minimum
            for(int i = 0; i < arr.Length; i++)
            {
                var diff = arr[i + m - 1] - arr[i];

                if(diff < minDiff)
                {
                    minDiff = diff;
                }
            }

            return minDiff;
        }
    }
}
