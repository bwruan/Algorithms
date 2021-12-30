using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Algorithms
{
    public class Construction
    {
        public TreeNode<int> ConstructTreeGivenPreAndIn(int[] preOrder, int[] inOrder, int inSt, int inEnd, int preSt)
        {
            if(inSt > inEnd)
            {
                return null;
            }

            var rootIndex = Search(inOrder, inSt, inEnd, preOrder[preSt]);
            var left = ConstructTreeGivenPreAndIn(inOrder, preOrder, inSt, rootIndex - 1, preSt + 1);
            var right = ConstructTreeGivenPreAndIn(inOrder, preOrder, rootIndex + 1, inEnd, preSt + 1 + (rootIndex - inSt));

            return new TreeNode<int>(inOrder[rootIndex], left, right);
        }

        public TreeNode<int> ConstructTreeGivenInAndPost(int[] inOrder, int[] postOrder, int inSt, int inEnd, int postEnd)
        {
            if (inSt > inEnd)
            {
                return null;
            }

            var rootIndex = Search(inOrder, inSt, inEnd, postOrder[postEnd]);
            var left = ConstructTreeGivenInAndPost(inOrder, postOrder, inSt, rootIndex - 1, postEnd - (inEnd - rootIndex));
            var right = ConstructTreeGivenInAndPost(inOrder, postOrder, rootIndex + 1, inEnd, postEnd - 1);

            return new TreeNode<int>(inOrder[rootIndex], left, right);
        }

        private int Search(int[] arr, int start, int end, int ele)
        {
            var i = start;
            for (i = start; i <= end; i++)
            {
                if (arr[i] == ele)
                {
                    break;
                }
            }

            return i;
        }
    }
}
