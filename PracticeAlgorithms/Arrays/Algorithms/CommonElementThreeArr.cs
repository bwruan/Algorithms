using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //3 arrs non-descending order (next element will always be bigger)
    //find common elements b/w the 3
    public class CommonElementThreeArr
    {
        public void FindCommonElement(int[] ar1, int[] ar2, int[] ar3)
        {
            //indexes for the three arrays
            int i = 0, j = 0, k = 0;

            //iterate through three arrays
            //if x = y and y = z, print any, and move to next index
            //if not move on to the next index
            while(i < ar1.Length && j < ar2.Length && k < ar3.Length)
            {
                if(ar1[i] == ar2[j] && ar2[j] == ar3[k]) // x = y = z
                {
                    Console.Write(ar1[i] + " ");
                    i++;
                    j++;
                    k++;
                }
                else if(ar1[i] < ar2[j]) //x < y
                {
                    i++;
                }
                else if(ar2[j] < ar3[k]) // y < z
                {
                    j++;
                }
                else //x > y and z < y aka z is smallest
                {
                    k++;
                }
            }
        }
    }
}
