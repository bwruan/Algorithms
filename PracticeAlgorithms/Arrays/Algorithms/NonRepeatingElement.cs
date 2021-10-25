using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //first non repeated element in arr
    public class NonRepeatingElement
    {
        public int FirstNonRepeat(int[] arr)
        {
            //empty dictionary
            var mapper = new Dictionary<int, int>();

            //add all element to dictionary
            for(int i = 0; i < arr.Length; i++)
            {
                //add to dictionary with value (count) = 1
                if (!mapper.ContainsKey(arr[i]))
                {
                    mapper.Add(arr[i], 1);
                }
                //if dictionary contains value
                //add 1 to value
                else
                {
                    mapper[arr[i]] += 1;
                }
            }

            //traverse through dictionary
            //print Key where value aka count = 1
            foreach(var map in mapper)
            {
                if(map.Value == 1)
                {
                    return map.Key;
                }
            }

            return -1;
        }
    }
}
