using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class ShuffleStrings
    {
        public bool ValidShuffle(string a, string b, string c)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            //check if c is same length as a and b
            //if not, c cannot be a shuffle of a and b, return false
            if(c.Length != (a.Length + b.Length))
            {
                return false;
            }

            //loop through char of string c
            while (k != c.Length - 1)
            {
                //check first char of c and a
                //if match, increase i by one and continue looping
                if (a[i] == c[k])
                {
                    i++;
                }

                //else check first char of c and b
                //if match, increase j by one continue looping and move on
                else if (b[j] == c[k])
                {
                    j++;
                }

                //if char does not match that of a or b, return false
                else
                {
                    return false;
                }

                //move c to next for next iteration
                k++;
            }

            return true;
        }
    }
}
