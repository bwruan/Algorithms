using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion.Algorithms
{
    //given string, provide all permutations (rearrangement order)
    public class PermutationOfString
    {
        public void PrintPermutations(string s, string answer)
        {
            if(s.Length == 0)
            {
                Console.Write(answer + " ");
                return;
            }

            for(int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                var left = s.Substring(0, i);
                var right = s.Substring(i + 1);
                var rest = left + right;

                PrintPermutations(rest, answer + ch);
            }


        }
    }
}
