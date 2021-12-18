using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Algorithms
{
    public class TreeTraversalRecursive
    {
        public void PrintPreorder(TreeNode<int> root)
        {
            if(root == null)
            {
                return;
            }

            Console.WriteLine(root.Data + " ");

            PrintPreorder(root.Left);

            PrintPreorder(root.Right);
        }

        public void PrintInorder(TreeNode<int> root)
        {
            if (root == null)
            {
                return;
            }

            PrintInorder(root.Left);

            Console.WriteLine(root.Data + " ");

            PrintInorder(root.Right);
        }

        public void PrintPostorder(TreeNode<int> root)
        {
            if (root == null)
            {
                return;
            }

            PrintPostorder(root.Left);

            PrintPostorder(root.Right);

            Console.WriteLine(root.Data + " ");
        }
    }
}
