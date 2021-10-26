using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //arr of 0 and 1, count # of subarr with equal 0s and 1s
    public class SubArrEqual1s0s
    {
        public int CountSubArrEqual1s0s(int[] arr)
        {
            var mapper = new Dictionary<int, int>();
            var sum = 0;
            var count = 0;

            //traverse array and replace 0s with -1s
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    arr[i] = -1;
                }

                sum += arr[i];

                //if sum is 0, implies that 0s and 1s are equal
                //as -1 + 1 = 0
                if(sum == 0)
                {
                    count++;
                }

                //if dictionary has sum, add count to value at sum
                if (mapper.ContainsKey(sum))
                {
                    count += mapper[sum];
                }

                //otherwise, add sum to dictionary and count is 1
                if (!mapper.ContainsKey(sum))
                {
                    mapper.Add(sum, 1);
                }

                //???
                else
                {
                    var v = mapper[sum] + 1;
                    mapper.Remove(sum);
                    mapper.Add(sum, v);
                }
            }

            return count;
        }
    }
}
