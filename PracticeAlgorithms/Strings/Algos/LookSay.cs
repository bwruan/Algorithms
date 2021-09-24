﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class LookSay
    {
        public string LookAndSay(int n)
        {
            // Base cases
            if (n == 1)
            {
                return "1";
            }

            if (n == 2)
            {
                return "11";
            }

            // Find n'th term by generating all terms from 3 to n-1.
            // Every term is generated using previous term

            // Initialize previous term
            string str = "11";

            for (int i = 3; i <= n; i++)
            {
                // In below for loop, previous character is processed in current iteration. 
                //Dummy character added to make sure that loop runs one extra iteration.
                str += '$';
                int len = str.Length;

                // Initialize count of matching chars                
                int cnt = 1;

                // Initialize i'th term in series
                string tmp = ""; 

                char[] arr = str.ToCharArray();

                // Process previous term to find the next term
                for (int j = 1; j < len; j++)
                {
                    // If current character does't match
                    if (arr[j] != arr[j - 1])
                    {
                        // Append count of str[j-1] to temp
                        tmp += cnt + 0;

                        // Append str[j-1]
                        tmp += arr[j - 1];

                        // Reset count
                        cnt = 1;
                    }

                    // If matches, then increment count of matching characters
                    else cnt++;
                }

                // Update str
                str = tmp;
            }

            return str;
        }
    }
}
