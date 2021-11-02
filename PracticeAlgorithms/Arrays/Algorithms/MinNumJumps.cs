using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //arr of int representing max num of steps
    //min num of jumps needed to reach end of array
    //if 0, cannot move and end is not reachable
    public class MinNumJumps
    {
        public int MinJumps(int[] arr)
        {
            var jumps = new int[arr.Length];
            
            //if first element is 0 or array is empty, return max int aka unreachable
            if(arr[0] == 0 || arr.Length == 0)
            {
                return int.MaxValue;
            }

            jumps[0] = 0;

            for(int i = 1; i < arr.Length; i++)
            {
                jumps[i] = int.MaxValue;

                for (int j = 0; j < i; j++)
                {
                    if(i <= j + arr[j] && jumps[j] != int.MaxValue)
                    {
                        jumps[i] = Math.Min(jumps[i], jumps[j] + 1);
                        break;
                    }
                }
            }

            return jumps[arr.Length - 1];
        }
    }
}
