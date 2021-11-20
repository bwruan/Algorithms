using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion.Algorithms
{
    //given arr of elements, print all subsets
    public class FindAllSubsetsOfArr
    {
        public void FindSubsets(int[] arr)
        {
            //initialize a new empty [] sub of same length as given [] arr
            var sub = new int[arr.Length];
            //call helper function starting at index 0
            Find(arr, sub, 0);
        }

        //helper function that takes
        //3 args = given [] arr, 
        //current [] sub (represents state of current subset),
        //and int index to represent current index
        public void Find(int[] arr, int[] sub, int index)
        {
            //check if index = arr.length
            //if so, it means index is pointing outside of arr
            //which means finished iterating arr and finished constructing a subset
            //if the position variable p has iterated all elements   
            if (index == arr.Length)
            {
                //mechanism to print non zero elements  
                string s = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    if (sub[i] != 0)
                    {
                        s += sub[i].ToString();
                    }
                }
                Console.WriteLine(s);
            }
            else
            {
                //For not selecting the element  
                sub[index] = 0;
                Find(arr, sub, index + 1);

                //For selecting the element  
                sub[index] = arr[index];
                Find(arr, sub, index + 1);

            }
        }
    }
}
