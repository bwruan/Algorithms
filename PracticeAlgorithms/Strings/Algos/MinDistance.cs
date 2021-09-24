using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.Algos
{
    public class MinDistance
    {
        public int MinDistanceBtwnWords(string s, string w1, string w2)
        {
            //check if words provided are the same, if so length is 0
            if(w1 == w2)
            {
                return 0;
            }

            //variable for index of each target word 
            int index1 = -1;
            int index2 = -1;
            int distance = -1;

            //split string by blank and add each individual word into array
            string[] sArr = s.Split(" ");

            //assume length of string as minimum distance
            int minDis = sArr.Length;

            //loop through array and find target word and set index
            for (int i = 0; i < sArr.Length; i++)
            {
                if(sArr[i] != w1 || sArr[i] != w2)
                {
                    continue;
                }
                if(sArr[i].Equals(w1))
                {
                    index1 = i;
                }
                if (sArr[i].Equals(w2))
                {
                    index2 = i;
                }

                //get difference b/w the two indexes for distance
                distance = Math.Abs(index1 - index2);

                //compare to prev assumed minimum distance
                if(distance < minDis)
                {
                    minDis = distance;
                }
            }

            return minDis;
        }
    }
}
