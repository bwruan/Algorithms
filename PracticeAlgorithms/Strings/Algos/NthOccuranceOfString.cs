using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class NthOccuranceOfString
    {
        public int findIndexOfNthOccur(string a, char c, int n)
        {
            int occur = 0;

            //loop to find Nth occurance of char c
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] == c)
                {
                    occur += 1;
                }

                if(occur == n)
                {
                    return i;
                }
            }

            //if occur != n after looping, return -1 as no solution
            return -1;
        }
    }
}
