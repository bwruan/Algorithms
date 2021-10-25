using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //arr of postive and negative int, rearrage arr to be {+, -, +, -,...}
    //if more positive/neg, they will appear at end of array
    //only have O(1) space, order is important
    public class RearrageArrAltPosNeg
    {
        public void RotateRight(int[] arr, int outOfPlace, int cur)
        {
            //set temp = current element
            var temp = arr[cur];

            //loop from current index backwards
            //shift everything to the right
            //element at current index is now at index of outofplace
            for(int i = cur; i > outOfPlace; i--)
            {
                arr[i] = arr[i - 1];
                arr[outOfPlace] = temp;
            }
        }

        //order important (GFG code..???)
        public void AltPosNeg(int[] arr)
        {
            int outOfPlace = -1;

            for(int i = 0; i < arr.Length; i++)
            {
                if(outOfPlace >= 0)
                {
                    if((arr[i] >= 0 && arr[outOfPlace] < 0) || (arr[i] < 0 && arr[outOfPlace] >= 0))
                    {
                        RotateRight(arr, outOfPlace, i);

                        if(i - outOfPlace > 2)
                        {
                            outOfPlace = outOfPlace + 2;
                        }
                        else
                        {
                            outOfPlace = -1;
                        }
                    }
                }

                if(outOfPlace == -1)
                {
                    if((arr[i] >= 0 && (i & 0x01) == 0) || arr[i] < 0 && (i & 0x01) == 1)
                    {
                        outOfPlace = i;
                    }
                }
            }
        }

        //order not important
        public void AlternatePosNeg(int[] arr)
        {

        }
    }
}
