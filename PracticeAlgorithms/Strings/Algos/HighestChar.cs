using System;
using System.Collections.Generic;
using System.Linq;

namespace Strings.Algos
{
    public class HighestChar
    {
        public void CharHighest(string a)
        {
            //creating a dictionary with each character of word as the key and the number of times it appears in the word as the value
            var mapper = new Dictionary<char, int>();

            //looping through each character of the string
            foreach (var c in a)
            {
                //if the dictionary does not have the character, add it in and set value to one
                //otherwise add 1 to the value if it is already in the dictionary
                if (!mapper.ContainsKey(c))
                {
                    mapper.Add(c, 1);
                }
                else
                {
                    mapper[c] += 1;
                }
            }

            //loop through dictionary and find key with highest value
            foreach (var map in mapper)
            {
                if(map.Value != mapper.Values.Max())
                {
                    continue;
                }

                Console.WriteLine(map.Key);
            }
        }
    }
}
