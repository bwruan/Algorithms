using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //arr of + and - num, find if there is subarr of size at least 1 where sum = 0
    public class SubArrSumZero
    {
        public bool SubArraySumZeroExist(int[] arr)
        {
            //empty hash shet
            var hs = new HashSet<int>();

            //initialize sum
            var sum = 0;

            //traverse array
            for(int i = 0; i < arr.Length; i++)
            {
                //add current element to sum
                sum += arr[i];

                //return true if following cases:
                //1. current element is 0
                //2. sum of elements from 0 to i is 0
                //3. sum already present in hashset
                //hashset sum can only be present again, if somewhere along between when sum first appeared to second appearance became 0
                //e.g. {1, 4, -2, -2, 3,...} sum goes from 1 -> 5 -> 3 -> 1 --> subarr {4, -2, -2} sums to 0
                if(arr[i] == 0 || sum == 0 || hs.Contains(sum))
                {
                    return true;
                }

                //otherwise add sum to hashset and keep looping
                hs.Add(sum);
            }

            //return false if we have no subarr (aka nothing satified prior return true conditions)
            return false;
        }
    }
}
