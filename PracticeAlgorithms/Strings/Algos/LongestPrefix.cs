using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class LongestPrefix
    {
        public string LongestCommonPrefix(string a, string b)
        {
            //instantiate variable for prefix
            var prefix = "";

            //loop and compare two string
            for(int i = 0; i < a.Length - 1; i++)
            {
                for(int j = 0; j < b.Length - 1; j++)
                {
                    //if they do not match, break out of loop
                    if(a[i] != b[j])
                    {
                        break;
                    }

                    // If they match, append the character to the prefix variable
                    prefix += a[i];
                }
            }

            return prefix;
        }
    }
}
