using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //find length of longest sub-sequence of consecutive int
    //order not important
    public class LongestConsecSubSeq
    {
        public int LongestSubseq(int[] arr)
        {
            var hs = new HashSet<int>();
            var result = 0;

            //hash all elements of arr
            for(int i = 0; i < arr.Length; i++)
            {
                hs.Add(arr[i]);
            }

            //check each possible seq from start
            //update optimal length
            for (int i = 0; i < arr.Length; i++)
            {
                //current element is starting element of sequence
                if(!hs.Contains(arr[i] - 1))
                {
                    //check for next elements in seq
                    var j = arr[i];
                    while (hs.Contains(j))
                    {
                        j++;
                    }

                    //update optimal length if this length is more
                    if(result < j - arr[i])
                    {
                        result = j - arr[i];
                    }
                }
            }

            return result;
        }
    }
}
