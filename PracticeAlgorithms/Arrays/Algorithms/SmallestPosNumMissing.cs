using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //arr of unsorted pos and neg elements
    //find smallest pos num missing from arr
    public class SmallestPosNumMissing
    {
        //extra space
        public int MissingPosNum(int[] arr)
        {
            //create hashset (extra space)
            var hs = new HashSet<int>();
            var missing = 0;

            //traverse arr, if pos num, add to hash
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    hs.Add(arr[i]);
                }
            }

            //traverse hash for all pos int starting from 1
            for (int i = 1; i < int.MaxValue; i++)
            {
                //if hash does not contain the int, break out of loop and return missing int 
                if (!hs.Contains(i))
                {
                    missing = i;
                    break;
                }
            }

            return missing;
        }
    }
}
