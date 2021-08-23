using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class VowelsAndConsonants
    {
        public void CountNumOfVowelsAndConsonants(string word)
        {
            var vowelCount = 0;
            var consonantCount = 0;

            //convert input into char[]
            var wordArr = word.ToCharArray();

            //loop through char[] and add 1 to count depending on if char is a vowel or consonant
            for(int i = 0; i < wordArr.Length - 1; i++)
            {
                if (wordArr[i] == 'a' || wordArr[i] == 'e' || wordArr[i] == 'i' || wordArr[i] == 'o' || wordArr[i] == 'u'
                    || wordArr[i] == 'A' || wordArr[i] == 'E' || wordArr[i] == 'I' || wordArr[i] == 'O' || wordArr[i] == 'U')
                {
                    vowelCount += 1;
                }
                else
                {
                    consonantCount += 1;
                }
            }
        }
    }
}
