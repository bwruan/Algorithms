using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Algorithms
{
    public class BinarySearchTree
    {
        public bool BinarySearchRecursive(int[] arr, int x, int left, int right)
        {
            if(left > right)
            {
                return false;
            }

            var mid = (left + right) / 2;

            if (arr[mid] == x)
            {
                return true;
            }

            else if (x < arr[mid])
            {
                return BinarySearchRecursive(arr, x, 0, mid - 1);
            }

            else
            {
                return BinarySearchRecursive(arr, x, mid + 1, right);
            }
        }

        public bool BinarySearchIterative(int[] arr, int x)
        {
            var left = 0;
            var right = arr.Length - 1;

            while(left <= right)
            {
                var mid = (left + right) / 2;

                if (arr[mid] == x)
                {
                    return true;
                }

                else if (x < arr[mid])
                {
                    right = mid - 1;
                }

                else
                {
                    left = mid + 1;
                }
            }

            return false;
        }

        public TreeNode<int> ConstructBST(int[] sortedArr, int left, int right)
        {
            if(sortedArr.Length == 0 || left > right)
            {
                return null;
            }

            var mid = (left + right) / 2;
            var root = new TreeNode<int>(sortedArr[mid], null, null);

            var leftRoot = ConstructBST(sortedArr, left, mid - 1);
            var rightRoot = ConstructBST(sortedArr, mid + 1, right);

            root.Left = leftRoot;
            root.Right = rightRoot;

            return root;
        }
    }
}
