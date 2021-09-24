using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class Pangram
    {
        public bool IsPangram(string s)
        {
            //lowercase everything in given string to avoid counting uppercases as a separate char
            var str = s.ToLower();

            //use dictionary to store mappings of chars and appearance.
            var map = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                //add char to map if it does not contain the char and is alphabet
                if (!map.ContainsKey(str[i]) && str[i] >= 'a' && str[i] <= 'z')
                {
                    map.Add(str[i], 1);
                }
                else
                {
                    map[str[i]] += 1;
                }
            }

            //check length of dictionary to equal to 26 (26 letters in Alphabet)
            if(map.Count != 26)
            {
                return false;
            }

            return true;
        }
    }
}
