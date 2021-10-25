using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //arr of int and sum, find pairs in arr that add to sum
    public class PairsWithSum
    {
        public int PairCount(int[] arr, int sum)
        {
            var mapper = new Dictionary<int, int>();

            //store counts of all elements in mapper
            for(int i = 0; i < arr.Length; i++)
            {
                if (!mapper.ContainsKey(arr[i]))
                {
                    mapper[arr[i]] = 0;
                }

                mapper[arr[i]] = mapper[arr[i]] + 1;
            }

            int count2x = 0;

            //loop through each element and increment count (every pair counted 2x)
            for(int i = 0; i < arr.Length; i++)
            {
                if(mapper[sum - arr[i]] != 0)
                {
                    count2x += mapper[sum - arr[i]];
                }

                //if(arr[i], arr[i]) pair satisfy condition, count need to decrease by one
                //so that (arr[i], arr[i]) pair not considered
                if(sum - arr[i] == arr[i])
                {
                    count2x--;
                }
            }

            //return half the twice count
            return count2x / 2;
        }
    }
}
