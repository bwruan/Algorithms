using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class Palindrome
    {
        public bool CheckIfPalindrome(string word)
        {
            //reverse the string
            var wordArr = word.ToCharArray();
            var reverseWord = "";

            for (int i = wordArr.Length - 1; i > -1; i--)
            {
                reverseWord += wordArr[i];
            }

            //if string and the reverse of it are not equal to each other, return false
            if(reverseWord != word)
            {
                return false;
            }

            return true;
        }
    }
}
