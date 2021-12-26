using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Algorithms
{
    public class GivenXOrdersPrintYOrder
    {
        public void PrintPostGivenPreAndIn(int[] inOrder, int[] preOrder, int inStrt, int inEnd, int preStrt)
        {
            if(inStrt > inEnd)
            {
                return;
            }

            var root = Search(inOrder, inStrt, inEnd, preOrder[preStrt]);

            PrintPostGivenPreAndIn(inOrder, preOrder, inStrt, root - 1, preStrt + 1);

            PrintPostGivenPreAndIn(inOrder, preOrder, root + 1, inEnd, preStrt + (root - inStrt) + 1);

            Console.Write(inOrder[root] + " ");
        }

        public void PrintPreGivenInAndPost(int[] inOrder, int[] postOrder, int inStrt, int inEnd, int postEnd)
        {
            if (inStrt > inEnd)
            {
                return;
            }

            var root = Search(inOrder, inStrt, inEnd, postOrder[postEnd]);
            Console.Write(inOrder[root] + " ");


            PrintPreGivenInAndPost(inOrder, postOrder, inStrt, root - 1, postEnd - (inEnd - root) - 1);

            PrintPreGivenInAndPost(inOrder, postOrder, root + 1, inEnd, postEnd - 1);
        }

        private int Search(int[] arr, int start, int end, int ele)
        {
            var i = start;
            for(i = start; i <= end; i++)
            {
                if(arr[i] == ele)
                {
                    break;
                }
            }

            return i;
        }
    }
}
