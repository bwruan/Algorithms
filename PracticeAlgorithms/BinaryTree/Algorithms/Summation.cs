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
            if(root == null)
            {
                return;
            }

            var stk = new Stack<TreeNode<int>>();
            stk.Push(root);

            var parent = new Dictionary<TreeNode<int>, TreeNode<int>>();

            parent.Add(root, null);

            while(stk.Count != 0)
            {
                TreeNode<int> curr = stk.Pop();

                if(curr.Left == null && curr.Right == null)
                {
                    PrintTopToBottom(curr, parent);
                }

                if(curr.Right != null)
                {
                    parent.Add(curr.Right, curr);
                    stk.Push(curr.Right);
                }

                if(curr.Left != null)
                {
                    parent.Add(curr.Left, curr);
                    stk.Push(curr.Left);
                }
            }
        }

        public int SumLongestRootToLeafPath(TreeNode<int> root, List<int> currPath, int maxLen)
        {            
            if(root == null)
            {
                return 0;
            }

            if(root.Left == null && root.Right == null)
            {
                currPath.Add(root.Data);
                if(currPath.Count != maxLen)
                {
                    currPath.Remove(root.Data);
                    return 0;
                }
                
                var sum = 0;
                foreach(var data in currPath)
                {
                    sum += data;
                }

                currPath.Remove(root.Data);
                return sum;
            }

            currPath.Add(root.Data);
            var leftSum = SumLongestRootToLeafPath(root.Left, currPath, maxLen);
            var rightSum = SumLongestRootToLeafPath(root.Right, currPath, maxLen);

            currPath.Remove(root.Data);

            return leftSum + rightSum;
        }

        public int MaxLeafToRootPathSum(TreeNode<int> root, List<int> currPath, ref int maxSum)
        {
            if(root == null)
            {
                return 0;
            }

            if (root.Left == null && root.Right == null)
            {
                var sum = 0;
                currPath.Add(root.Data);

                foreach (var data in currPath)
                {
                    sum += data;
                }

                currPath.Remove(root.Data);

                if(sum > maxSum)
                {
                    maxSum = sum;
                }
                
                return maxSum;
            }

            currPath.Add(root.Data);
            MaxLeafToRootPathSum(root.Left, currPath, ref maxSum);
            MaxLeafToRootPathSum(root.Right, currPath, ref maxSum);
            currPath.Remove(root.Data);

            return maxSum;
        }

        public void PrintAllPathWithSumK(TreeNode<int> root, int k, List<int> currPath)
        {
            if (root == null)
            {
                return;
            }

            if(root.Data == k)
            {
                Console.WriteLine(root.Data);
            }

            currPath.Add(root.Data);
            PrintAllPathWithSumK(root.Left, k, currPath);
            PrintAllPathWithSumK(root.Right, k, currPath);

            var sum = 0;

            for(var i = currPath.Count -1; i >= 0; i--)
            {
                sum += currPath[i];

                if(sum == k)
                {
                    for(var j = 0; j < currPath.Count; j++)
                    {
                        Console.Write(currPath[j] + " ");
                    }
                    Console.Write("\n");
                }
            }

            currPath.RemoveAt(currPath.Count - 1);
        }

        public int MaxPathSumBtwnTwoLeaves(TreeNode<int> root, ref int maxSum)
        {
            if(root == null)
            {
                return 0;
            }

            if(root.Left == null && root.Right == null)
            {
                return root.Data;
            }

            var leftSum = MaxPathSumBtwnTwoLeaves(root.Left, ref maxSum);
            var rightSum = MaxPathSumBtwnTwoLeaves(root.Right, ref maxSum);

            if(root.Left != null && root.Right != null)
            {
                maxSum = Math.Max(maxSum, root.Data + leftSum + rightSum);

                return Math.Max(leftSum, rightSum) + root.Data;
            }

            return (root.Left == null) ? root.Data + rightSum : root.Data + leftSum;
        }

        public int LargestSubtreeSum(TreeNode<int> root, ref int maxSum)
        {
            if(root == null)
            {
                return 0;
            }

            if(root.Left == null && root.Right == null)
            {
                return root.Data;
            }

            var ls = LargestSubtreeSum(root.Left, ref maxSum);
            var rs = LargestSubtreeSum(root.Right, ref maxSum);

            maxSum = Math.Max(maxSum, root.Data + ls + rs);

            return root.Data + ls + rs;
        }

        private void PrintTopToBottom(TreeNode<int> curr, Dictionary<TreeNode<int>, TreeNode<int>> parent)
        {
            var stack = new Stack<TreeNode<int>>();

            while(curr != null)
            {
                stack.Push(curr);
                curr = parent[curr];
            }

            while(stack.Count != 0)
            {
                curr = stack.Pop();
                Console.Write(curr.Data + " ");
            }

            Console.WriteLine();
        }
    }
}
