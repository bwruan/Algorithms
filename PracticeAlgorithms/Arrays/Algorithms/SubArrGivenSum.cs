using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //unsorted arr, find subarr that adds to given num
    //print all subarr that can sum to given num
    public class SubArrGivenSum
    {
        public void SubArrWithSum(int[] arr, int sum)
        {
            //initialize variable to keep track of current sum and start and end index of current sum
            int current = 0;
            int start = 0;
            int end = -1;

            //store key (sum) and value (index)
            var mapper = new Dictionary<int, int>();

            //loop through Arr
            for(int i = 0; i < arr.Length; i++)
            {
                current = current + arr[i];

                //check if current - sum = 0
                //if 0, subarr is starting from index 0, stop loop
                if(current - sum == 0)
                {
                    start = 0;
                    end = i;
                    break;
                }

                //if mapper has value, we already have subarr with sum, stop loop
                if(mapper.ContainsKey(current - sum))
                {
                    start = mapper[current - sum] + 1;
                    end = i;
                    break;
                }

                //if mapper does not have value, add it in
                mapper[current] = i;
            }

            //if end index remains at -1, it means we reached end without a sum
            if(end == -1)
            {
                Console.WriteLine("No subarray with given sum exists");
            }
            else
            {
                Console.WriteLine("Sum found between indexes " + start + " to" + end);
            }
        }
    }
}
