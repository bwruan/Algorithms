using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //arr of unsorted pos and neg elements
    //find smallest pos num missing from arr
    public class SmallestPosNumMissing
    {
        //extra space
        public int MissingPosNum(int[] arr)
        {
            //create hashset (extra space)
            var hs = new HashSet<int>();
            var missing = 0;

            //traverse arr, if pos num, add to hash
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    hs.Add(arr[i]);
                }
            }

            //traverse hash for all pos int starting from 1
            for (int i = 1; i < int.MaxValue; i++)
            {
                //if hash does not contain the int, break out of loop and return missing int 
                if (!hs.Contains(i))
                {
                    missing = i;
                    break;
                }
            }

            return missing;
        }

        //no extra space
        public int Segregate(int[] arr)
        {
            var j = 0;

            //segregate negatives to left side of arr and pos to right side
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= 0)
                {
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    j++;
                }
            }

            return j;
        }

        //find smallest pos missing num
        public int SmallestMissingPosNum(int[] arr)
        {
            //mark arr[i] as visited by making arr[arr[i]-1] negative
            for(int i = 0; i < arr.Length; i++)
            {
                if(Math.Abs(arr[i]) -1 < arr.Length && arr[Math.Abs(arr[i]) - 1] > 0)
                {
                    arr[Math.Abs(arr[i]) - 1] = -arr[Math.Abs(arr[i]) - 1];
                }
            }

            //reutrn first index value that is positive
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    return i + 1;
                }
            }

            //add 1 b/c index starts at 0
            return arr.Length + 1;
        }

        public int FindMissing(int[] arr)
        {
            var shift = Segregate(arr);
            var arr2 = new int[arr.Length - shift];
            var j = 0;

            for(int i = shift; i < arr.Length; i++)
            {
                arr2[j] = arr[i];
                j++;
            }

            return SmallestMissingPosNum(arr2);
        }
    }
}
