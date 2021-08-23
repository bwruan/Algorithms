using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class ReverseString
    {
        public void PrintStringInReverse(string word)
        {
            //convert the word into char[]
            var wordArr = word.ToCharArray();

            //set variable for the reverse word
            var reverseWord = "";

            //loop through array starting at the last index and going backwards
            //set reverse word variable to be equal the character in the array + the next until end of loop
            for(int i = wordArr.Length - 1; i > -1; i--)
            {
                reverseWord += wordArr[i];
            }

            Console.WriteLine(reverseWord);
        }
    }
}
