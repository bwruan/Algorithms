using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class SubstringKChar
    {
        public int SubstringWithKChar(string a, int k)
        {
            // Initialize result
            int res = 0;

            // To store count of characters from 'a' to 'z'
            int[] cnt = new int[26];

            // Consider all substrings beginning with
            // str[i]
            for (int i = 0; i < a.Length; i++)
            {
                int dist_count = 0;

                // Initializing count array with 0
                Array.Clear(cnt, 0, cnt.Length);

                // Consider all substrings between str[i..j]
                for (int j = i; j < a.Length; j++)
                {
                    // If this is a new character for this
                    // substring, increment dist_count.
                    if (cnt[a[j] - 'a'] == 0)
                    {
                        dist_count++;
                    }

                    // Increment count of current character
                    cnt[a[j] - 'a']++;

                    // If distinct character count becomes k,
                    // then increment result.
                    if (dist_count == k)
                    {
                        res++;
                    }
                }
            }

            return res;
        }
    }
}
