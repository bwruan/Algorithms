using System;

namespace Strings.Algos
{
    public class Anagram
    {
        public bool CheckIfAnagram(string word, string anagram)
        {
            //check to see if the length of each word is the same, if not, cannot be anagram, return false
            if(word.Length != anagram.Length)
            {
                return false;
            }

            //if length matches, connect both into char[]
            var wordArr = word.ToCharArray();
            var anagramArr = anagram.ToCharArray();

            //sort the array
            Array.Sort(wordArr);
            Array.Sort(anagramArr);

            //loop through the array
            for(int i = 0; i < wordArr.Length - 1; i++)
            {
                //if the value at each index do not match, not an anagram return false
                //otherwise return true
                if(wordArr[i] != anagramArr[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
