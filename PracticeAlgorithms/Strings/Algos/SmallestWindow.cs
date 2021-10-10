using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class SmallestWindow
    {
        //smallest window of a to contain all of b
        public string MinWindowContainAllChar(string a, string b)
        {
            //check if string a is shorter than string b (pattern)
            if(a.Length < b.Length)
            {
                Console.WriteLine("No such window can exist.");
                return "";
            }

            int[] hash_b = new int[256];
            int[] hash_a = new int[256];
            

            //store occurence of characters of pattern
            for(int i = 0; i < b.Length; i++)
            {
                hash_b[b[i]]++;
            }

            int start = 0;
            int startIndex = -1;
            int minLen = int.MaxValue;
            int count = 0;

            //traverse a and count characters
            for(int j = 0; j < a.Length; j++)
            {
                //count occurence of characters of a
                hash_a[a[j]]++;

                //if a characters matches b's characters then increment count 
                if (hash_a[a[j]] <= hash_b[a[j]])
                {
                    count++;
                }

                //if all characters match
                if(count == b.Length)
                {
                    //try to minimize window
                    while(hash_a[a[start]] > hash_b[a[start]])
                    {
                        hash_a[a[start]]--;
                        start++;
                    }
                }

                //update window size
                int lenWindow = j - start + 1;
                if(minLen > lenWindow)
                {
                    minLen = lenWindow;
                    startIndex = start;
                }
            }

            //if no window is found
            if(startIndex == -1)
            {
                Console.WriteLine("No such window exists");
                return "";
            }

            //return substring starting from startIndex and length of minLen
            return a.Substring(startIndex, minLen);
        }
    }
}
