using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Algorithms
{
    public class Check
    {
        public bool CheckIfSubTree(TreeNode<int> root1, TreeNode<int> root2)
        {
            if(root2 == null && root1 != null)
            {
                return true;
            }

            if(root1 == null && root2 != null)
            {
                return false;
            }

            if(CheckIfIdentical(root1, root2))
            {
                return true;
            }

            return CheckIfSubTree(root1.Left, root2) || CheckIfSubTree(root1.Right, root2);
        }

        public int CheckIfSumTree(TreeNode<int> n, ref bool isSumTree)
        {
            if (n == null)
            {
                return 0;
            }

            if(n.Left == null && n.Right == null)
            {
                return n.Data;
            }

            var left = CheckIfSumTree(n.Left, ref isSumTree);
            var right = CheckIfSumTree(n.Right, ref isSumTree);

            if(n.Data != (left + right))
            {
                isSumTree = false;
                return int.MinValue;
            }

            return n.Data + left + right;
        }

        public bool CheckIfCousins(TreeNode<int> root, TreeNode<int> cousin1, TreeNode<int> cousin2)
        {
            var q = new Queue<TreeNode<int>>();
            q.Enqueue(root);

            var level = 1;
            var potCousin = new List<PotentialCousin>();

            while (q.Count > 0)
            {
                var size = q.Count;
                var i = 0;

                while (i < size)
                {
                    var curr = q.Dequeue();
                    if (curr.Left != null)
                    {
                        q.Enqueue(curr.Left);
                        if (curr.Left == cousin1 || curr.Left == cousin2)
                        {
                            var potentialC = new PotentialCousin(level + 1, curr, curr.Left);
                            potCousin.Add(potentialC);
                        }
                    }

                    if (curr.Right != null)
                    {
                        q.Enqueue(curr.Right);
                        if (curr.Right == cousin1 || curr.Right == cousin2)
                        {
                            var potentialC = new PotentialCousin(level + 1, curr, curr.Right);
                            potCousin.Add(potentialC);
                        }
                    }

                    i++;
                }
            }

            if (potCousin.Count != 2)
            {
                return false;
            }

            var c1 = potCousin[0];
            var c2 = potCousin[1];

            return c1.Level == c2.Level && c1.Parent != c2.Parent;
        }

        public bool CheckIfMirror(TreeNode<int> root1, TreeNode<int> root2)
        {
            if(root1.Data != root2.Data || root1 != null && root2 == null || root1 == null && root2 != null)
            {
                return false;
            }

            if(root1 == null && root2 == null)
            {
                return true;
            }

            return CheckIfMirror(root1.Left, root2.Right) && CheckIfMirror(root1.Right, root2.Left);
        }

        public bool CheckIfPerfectTree(TreeNode<int> root, int level, int depth)
        {
            if(root == null)
            {
                return true;
            }

            if((root.Left != null && root.Right == null) || (root.Left == null && root.Right != null))
            {
                return false;
            }

            if(root.Left == null && root.Right == null)
            {
                return (depth == level);
            }

            return CheckIfPerfectTree(root.Left, level + 1, depth) && CheckIfPerfectTree(root.Right, level + 1, depth);
        }

        public bool CheckIfFullTree(TreeNode<int> root)
        {
            if(root == null || (root.Left == null && root.Right == null))
            {
                return true;
            }

            if((root.Left != null && root.Right == null) || (root.Left == null && root.Right != null))
            {
                return false;
            }

            return CheckIfFullTree(root.Left) && CheckIfFullTree(root.Right);
        }

        public bool CheckIfIdentical(TreeNode<int> root1, TreeNode<int> root2)
        {
            if(root1 == null && root2 == null)
            {
                return true;
            }

            if((root1 != null && root2 == null) || (root1 == null && root2 != null) || (root1.Data != root2.Data))
            {
                return false;
            }

            return CheckIfIdentical(root1.Left, root2.Left) && CheckIfIdentical(root1.Right, root2.Right);
        }
    }
}
