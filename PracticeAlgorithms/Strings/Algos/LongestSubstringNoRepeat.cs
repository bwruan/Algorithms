using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class LongestSubstringNoRepeat
    {
        public int LongestSubstringLenNoRepeatChar(string a)
        {
            //store result
            int res = 0;

            //last index of all char initialized as -1
            int[] lastIndex = new int[256];
            Array.Fill(lastIndex, -1);

            //start current window
            int i = 0;

            for(int j = 0; j < a.Length; j++)
            {
                //find last index of a[j], update i as max of current value of i and last index plus 1
                i = Math.Max(i, lastIndex[a[j]] + 1);

                //update result if we get larger window
                res = Math.Max(res, j - 1 + 1);

                //update last index of j
                lastIndex[a[j]] = j;
            }

            return res;
        }
    }
}
