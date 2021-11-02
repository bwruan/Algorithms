using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //arrival and departure times of all trains - 2 arr
    //find min # of platforms required so no train waits
    public class MinPlatforms
    {
        public int MinNumOfPlatforms(int[] arr, int[] dep)
        {
            //Sort arrival and departure arrays
            Array.Sort(arr);
            Array.Sort(dep);
            
            //num of platforms required at a time
            var platRequired = 1;
            var results = 1;

            var i = 1;
            var j = 0;

            while(i < arr.Length && j < arr.Length)
            {
                if(arr[i] <= dep[j])
                {
                    platRequired++;
                    i++;
                }

                if(arr[i] > dep[i])
                {
                    platRequired--;
                    j++;
                }

                if(platRequired > results)
                {
                    results = platRequired;
                }
            }

            return results;
        }
    }
}
