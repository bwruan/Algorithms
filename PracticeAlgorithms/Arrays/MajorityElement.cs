using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    //find majority element in arr of size n 
    // majority element appears more than n/2 times
     public class MajorityElement
    {
        public void FindMajorityElement(int[] arr)
        {
            var mapper = new Dictionary<int, int>();

            //add all elements in arr into Dictionary
            for(int i = 0; i < arr.Length; i++)
            {
                //check if Dictionay has element, if so
                //check if the value aka count is > half the arr size
                //if so, print element and break out of the loop
                if (mapper.ContainsKey(arr[i]))
                {
                    mapper[arr[i]] += 1;

                    if (mapper[arr[i]] > arr.Length / 2)
                    {
                        Console.WriteLine("Majority elememt is: " + mapper[arr[i]]);
                    }

                    return;
                }
                //otherwise, add to Dictionary and set count = 1
                else
                {
                    mapper.Add(arr[i], 1);
                }
            }

            //if iterate to end of arr
            //means no majority element was found
            Console.WriteLine("No Majority Element found.");
        }
    }
}
