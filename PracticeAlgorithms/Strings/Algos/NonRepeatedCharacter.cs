using System;
using System.Collections.Generic;

namespace Strings.Algos
{
    public class NonRepeatedCharacter
    {
        public void PrintFirstNonRepeatedChar(string word)
        {
            //initiate a dictionary
            var mapper = new Dictionary<char, int>();

            //loop through word and add to dictionary and count of each word
            //if letter already exists in dictionary, add 1 to value, if not add it to dictionary and set value to 1
            foreach (var c in word)
            {
                if (!mapper.ContainsKey(c))
                {
                    mapper.Add(c, 1);
                }
                else
                {
                    mapper[c] += 1;
                }
            }

            //loop through dictionary, if the value does not equal to 1, keep looping
            //otherwise, print the key in which value does equal to 1
            foreach (var map in mapper)
            {
                if (map.Value != 1)
                {
                    continue;
                }

                Console.WriteLine(map.Key);
            }
        }
    }
}
