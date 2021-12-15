using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Algorithms
{
    public class TreeTraversalRecursive
    {
        public void PrintPreorder(Node<int> root)
        {
            if(root == null)
            {
                return;
            }

            Console.WriteLine(root.data + " ");

            PrintPreorder(root.left);

            PrintPreorder(root.right);
        }

        public void PrintInorder(Node<int> root)
        {
            if (root == null)
            {
                return;
            }

            PrintInorder(root.left);

            Console.WriteLine(root.data + " ");

            PrintInorder(root.right);
        }

        public void PrintPostorder(Node<int> root)
        {
            if (root == null)
            {
                return;
            }

            PrintPostorder(root.left);

            PrintPostorder(root.right);

            Console.WriteLine(root.data + " ");
        }
    }
}
