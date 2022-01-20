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

            return true;
        }

        //public bool CheckIfCousins(TreeNode<int> root, TreeNode<int> n1, TreeNode<int> n2)
        //{
        //    var q = new Queue<TreeNode<int>>();
        //    q.Enqueue(root);
        //    var level = 1;
        //    var potCousin = new List<PotentialCousinNode>();

        //    while (q.Count > 0)
        //    {
        //        var size = q.Count;
        //        var i = 0;
        //        while (i < size)
        //        {
        //            var curr = q.Dequeue();
        //            if (curr.Left != null)
        //            {
        //                q.Enqueue(curr.Left);
        //                if (curr.Left == n1 || curr.Left == n2)
        //                {
        //                    var potentialC = new PotentialCousinNode(level + 1, curr, curr.Left);
        //                }
        //            }

        //            if (curr.Right != null)
        //            {
        //                q.Enqueue(curr.Right);
        //                if (curr.Right == n1 || curr.Right == n2)
        //                {
        //                    var potentialC = new PotentialCousinNode(level + 1, curr, curr.Right);
        //                }
        //            }
        //            i++;
        //        }

        //        if (cousinCount != 2)
        //        {
        //            return false;
        //        }

        //        c1 = potentialC[0];
        //        c2 = potentialC[1];

        //        return c1.level == c2.level && c1.parent != c2.parent;
        //    }

        //    return true;
        //}

        //public class PotentialCousinNode
        //{
        //    public PotentialCousinNode(int l, TreeNode<T> p, Node c)
        //    {
        //        level = l;

        //    }
        //    int level;
        //    Node Parent;
        //    Node curr;
        //}

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

        public bool CheckIfPerfectTree(TreeNode<int> root)
        {
            //find max depth going left
            //leaf nodes all same level
            return true;
        }
    }
}
