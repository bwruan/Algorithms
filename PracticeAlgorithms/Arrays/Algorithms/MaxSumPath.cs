using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //2 sorted Arr, may have common elements
    //find sum of max sum path
    //switch from one arr to another at common element
    public class MaxSumPath
    {
        public int FindMaxPathSum(int[] ar1, int[] ar2)
        {
            //initialize index
            var i = 0;
            var j = 0;

            //initialize result and current sum of e/ arr
            var result = 0;
            var sum1 = 0;
            var sum2 = 0;

            //while i and j are still less than their resp arr.length
            //break out of loop if condition is not met
            while(i < ar1.Length && j < ar2.Length)
            {
                //if ar1[i] < ar2[j]
                if(ar1[i] < ar2[j])
                {
                    //sum1 += ar1[i], increment i
                    sum1 += ar1[i++];
                }
                //if ar1[i] < ar2[j]
                else if(ar1[i] > ar2[j])
                {
                    //sum2 += ar2[j], increment j
                    sum2 += ar2[j++];
                }
                //otherwise if ar1[i] = ar2[j]
                else
                {
                    //add larger of 2 sum to the number
                    //doesn't matter which one as both num are the same
                    result += Math.Max(sum1, sum2) + ar1[i];

                    //reset sums to 0
                    sum1 = 0;
                    sum2 = 0;

                    //increment both i and j
                    i++;
                    j++;
                }
            }

            //if broke out of prev loop
            //check if index i is still less than the ar1.length
            //if not, break out of loop
            while(i < ar1.Length)
            {
                //if so, sum1 += ar1[i], increment i
                sum1 += ar1[i++];
            }

            //if broke out of prev loop
            //check if index j is still less than the ar2.length
            //if not, break out of loop
            while (j < ar2.Length)
            {
                //if so, sum2 += ar2[j], increment j
                sum2 += ar2[j++];
            }

            //add prev result to the bigger of 2 sum
            result += Math.Max(sum1, sum2);

            return result;
        }
    }
}
