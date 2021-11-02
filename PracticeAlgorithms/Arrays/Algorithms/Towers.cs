using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //given heights of n toweres a value k
    //increase or decrease height of every tower by k (only once)
    //minimize diff b/w heights of tallest and shortest towers after mods
    public class Towers
    {
        public int MinDiffShortestTallestTower(int[] arr, int k)
        {
            //sort arr from smallest to largest elements
            Array.Sort(arr);
            

            var curSmall = arr[0] + k;
            var curBig = arr[arr.Length - 1] - k;
            var minDiff = curBig - curSmall;

            //traverse middle elements to find if there are other elements that can provide a smaller height diff
            for(int i = 1; i < arr.Length -1; i++)
            {
                var subK = arr[i] - k;
                var addK = arr[i] + k;

                //keep looping if not smallest/biggest
                if(subK >= curSmall || addK <= curBig)
                {
                    continue;
                }

                if(curBig - subK <= addK - curSmall)
                {
                    curSmall = subK;
                }
                else
                {
                    curBig = addK;
                }
            }

            return Math.Min(minDiff, (curBig - curSmall));
        }
    }
}
