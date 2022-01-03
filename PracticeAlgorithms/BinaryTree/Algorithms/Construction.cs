using LinkedList;
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

        public TreeNode<int> ConstructTreeFromLinkedList(Node<int> head)
        {
            if (head == null)
            {
                return null;
            }

            var queue = new Queue<TreeNode<int>>();
            var root = new TreeNode<int>(head.Data, null, null);

            queue.Enqueue(root);

            var curr = head.Next;
            var isLeft = true;

            while (curr != null)
            {
                var node = queue.Peek();
                if (isLeft)
                {
                    var left = new TreeNode<int>(curr.Data, null, null);
                    node.Left = left;
                    queue.Enqueue(left);
                    isLeft = false;
                }
                else
                {
                    var right = new TreeNode<int>(curr.Data, null, null);
                    node.Right = right;
                    queue.Enqueue(right);
                    isLeft = true;
                    queue.Dequeue();
                }

                curr = curr.Next;
            }

            return root;
        }

        public TreeNode<int> ConstructTreeWithPreAndMirror(int[] preOrder, int[] mirror, int preSt, int preEnd, int mirSt, int mirEnd)
        {
            if (preSt > preEnd)
            {
                return null;
            }

            if (preSt + 1 > preEnd)
            {
                return new TreeNode<int>(preOrder[preSt], null, null);
            }

            var next = preOrder[preSt + 1];
            var nextIndex = Search(mirror, mirSt, mirEnd, next);
            var left = ConstructTreeWithPreAndMirror(preOrder, mirror, preSt + 1, preSt + (mirEnd - nextIndex) + 1, nextIndex, mirEnd);
            var right = ConstructTreeWithPreAndMirror(preOrder, mirror, preSt + 1 + (mirEnd - nextIndex + 1), preEnd, mirSt + 1, next - 1);

            return new TreeNode<int>(preOrder[preSt], left, right);
        }

        public TreeNode<int> ConstructSpecialTreeGivenIn(int[] inOrder, int inSt, int inEnd)
        {
            if(inSt > inEnd)
            {
                return null;
            }

            var maxIndex = FindMaxIndex(inOrder, inSt, inEnd);
            var left = ConstructSpecialTreeGivenIn(inOrder, inSt, maxIndex - 1);
            var right = ConstructSpecialTreeGivenIn(inOrder, maxIndex + 1, inEnd);

            return new TreeNode<int>(inOrder[maxIndex], left, right);
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

        private int FindMaxIndex(int[] arr, int start, int end)
        {
            var max = int.MinValue;
            var maxIndex = -1;
            for (var i = start; i <= end; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
