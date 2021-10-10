using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class MinNumRepitition
    {
        public int MinimumRepititionSoBIsSubstringOfA(string a, string b)
        {
            //store min # of reps, start at 1 as string a is not empty/null
            //there is already "1" rep
            int rep = 1;

            //store repeated string
            string s = a;

            //keep looping as long as string s is still shorter than string b
            while(s.Length < b.Length)
            {
                s += a;
                rep++;
            }

            //check to see if a contains string b
            //if doesn't return -1 as no solution exists
            if (!s.Contains(b))
            {
                return -1;
            }
            //otherwise return the # of repetition
            else
            {
                return rep;
            }
        }
    }
}
