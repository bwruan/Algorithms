using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class OccuranceOfGivenChar
    {
        public void CharOccurance(string word, char ch)
        {
            //creating a dictionary with each character of word as the key and the number of times it appears in the word as the value
            var mapper = new Dictionary<char, int>();

            //looping through each character of the word
            foreach (var c in word)
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

            //loop through dictionary to find given character
            //print out value (aka occurance) once finds character
            foreach (var map in mapper)
            {
                if(map.Key != ch)
                {
                    continue;
                }
                else if(map.Key == ch)
                {
                    Console.WriteLine(map.Value);
                }
            }
        }
    }
}
