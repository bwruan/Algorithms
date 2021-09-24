using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class KAnagrams
    {
        public bool AreKAnagrams(string a, string b, int k)
        {
            //check if strings are same length
            if(a.Length != b.Length)
            {
                return false;
            }

            int[] hash_a = new int[26];

            //store the occurrence of all characters in a hash_array
            for (int i = 0; i < a.Length; i++)
            {
                hash_a[a[i] - 'a']++;
            }

            //store the occurrence of all characters in a hash_array
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (hash_a[b[i] - 'a'] > 0)
                {
                    hash_a[b[i] - 'a']--;
                }
                else
                {
                    count++;
                }

                if (count > k)
                {
                    return false;
                }
            }

            //return true if count is less than or equal to k
            return true;
        }
    }
}
