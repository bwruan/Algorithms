using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Algorithms
{
    public class Summation
    {
        public int SumOfTree(TreeNode<int> root)
        {
            if(root == null)
            {
                return 0;
            }

            return root.Data + SumOfTree(root.Left) + SumOfTree(root.Right);
        }

        public int SumOfNodesWithChildX(TreeNode<int> root, int x)
        {
            if(root == null)
            {
                return 0;
            }

            var leftSum = SumOfNodesWithChildX(root.Left, x);
            var rightSum = SumOfNodesWithChildX(root.Right, x);

            var currSum = 0;

            if((root.Left != null && root.Left.Data == x) || (root.Right != null && root.Right.Data == x))
            {
                currSum += root.Data;
            }

            return currSum + leftSum + rightSum;
        }

        public int SumOfLeftLeaves(TreeNode<int> root)
        {
            if(root == null)
            {
                return 0;
            }

            var sum = 0;

            if(root.Left != null && root.Left.Left == null && root.Left.Right == null)
            {
                sum += root.Left.Data;
            }
            else
            {
                sum += SumOfLeftLeaves(root.Left);
            }

            sum += SumOfLeftLeaves(root.Right);

            return sum;
        }

        public int SumOfRightLeaves(TreeNode<int> root)
        {
            if(root == null)
            {
                return 0;
            }

            var sum = 0;

            if(root.Right != null && root.Right.Right == null && root.Right.Left == null)
            {
                sum += root.Right.Data;
            }
            else
            {
                sum += SumOfRightLeaves(root.Right);
            }

            sum += SumOfRightLeaves(root.Left);

            return sum;
        }

        public bool PairNodeSumEqualToRoot(TreeNode<int> root, HashSet<int> tracker, int n)
        {
            if(root == null)
            {
                return false;
            }

            if(tracker.Contains(n - root.Data))
            {
                return true;
            }

            tracker.Add(root.Data);
            var hasPair = PairNodeSumEqualToRoot(root.Left, tracker, n) || PairNodeSumEqualToRoot(root.Right, tracker, n);
            tracker.Remove(root.Data);

            return hasPair;
        }

        public void PrintPathWithoutRecursion(TreeNode<int> root)
        {

        }
    }
}
