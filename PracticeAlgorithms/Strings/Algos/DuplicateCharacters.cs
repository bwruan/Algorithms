using System;
using System.Collections.Generic;

namespace Strings.Algos
{
    public class DuplicateCharacters
    {
        public void PrintDuplicateCharaters(string word)
        {
            //creating a dictionary with each character of word as the key and the number of times it appears in the word as the value
            var mapper = new Dictionary<char, int>();

            //looping through each character of the word
            foreach(var c in word)
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

                    //breaking down what is happening in the equation mapper[c] += 1
                    //var val = mapper[c];
                    //val += 1;
                    //mapper[c] = val;
                }
            }

            //after looping through the word, loop through the dictionary, if the value is less than or equal to 1, keep looping
            //otherwise, print the key aka duplicate character
            foreach(var map in mapper)
            {
                if(map.Value <= 1)
                {
                    continue;
                }

                Console.WriteLine(map.Key);
            }
        }
    }
}
