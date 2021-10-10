using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class LenKSubstringKChar
    {
        public int SubstringOfLenKWithKChar(string a, int k)
        {
            //store count of substring that fit requisits
            //store and tally each char and count
            var count = 0;
            var map = new Dictionary<char, int>();

            //store occurance of first K length substring
            for(int i = 0; i < k; i++)
            {
                if (!map.ContainsKey(a[i]))
                {
                    map[a[i]] = 1;
                }
                else
                {
                    map[a[i]]++;
                }
            }

            if(map.Count == k)
            {
                count++;
            }

            for(int i = k; i < a.Length; i++)
            {
                if (!map.ContainsKey(a[i]))
                {
                    map[a[i]] = 1;
                }
                else
                {
                    map[a[i]]++;
                }

                map[a[i - k]]--;

                if(map[a[i-k]] == 0)
                {
                    map.Remove(a[i - k]);
                }

                if (map.Count == k)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
