using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Algorithms
{
    public class LastCommonAncestor
    {
        public TreeNode<int> FindLCA(TreeNode<int> root, TreeNode<int> n1, TreeNode<int> n2)
        {
            if(root == null)
            {
                return null;
            }

            if(root == n1 || root == n2)
            {
                return root;
            }

            var left = FindLCA(root.Left, n1, n2);
            var right = FindLCA(root.Right, n1, n2);

            if(left != null && right != null)
            {
                return root;
            }

            return (left != null) ? left : right;
        }

        public int FindDistance(TreeNode<int> root, TreeNode<int> a, TreeNode<int> b)
        {
            var lca = FindLCA(root, a, b);

            if(lca == null)
            {
                return -1;
            }

            var d1 = (a == lca) ? 0 : FindLevelBtwnNodes(lca, a, 0);
            var d2 = (b == lca) ? 0: FindLevelBtwnNodes(lca, b, 0);

            return d1 + d2;
        }

        private int FindLevelBtwnNodes(TreeNode<int> n1, TreeNode<int> n2, int level)
        {
            if(n1 == n2)
            {
                return level;
            }

            if(n1 == null)
            {
                return 0;
            }

            var fromLeft = FindLevelBtwnNodes(n1.Left, n2, level + 1);
            var fromRight = FindLevelBtwnNodes(n1.Right, n2, level + 1);

            return (fromLeft != 0) ? fromLeft : fromRight;
        }
    }
}
