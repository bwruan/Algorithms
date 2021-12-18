using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Algorithms
{
    public class TreeTraversalIterative
    {
        public void PrintPreorder(TreeNode<int> root)
        {
            if (root == null)
            {
                return;
            }

            var stack = new Stack<TreeNode<int>>();
            stack.Push(root);

            while(stack.Count > 0)
            {
                var node = stack.Pop();
                Console.Write(node.Data + " ");

                if(node.Right != null)
                {
                    stack.Push(node.Right);
                }

                if(node.Left != null)
                {
                    stack.Push(node.Left);
                }
            }
        }

        public void PrintInorder(TreeNode<int> root)
        {
            if (root == null)
            {
                return;
            }

            var stack = new Stack<TreeNode<int>>();
            TreeNode<int> curr = root;

            while (curr != null || stack.Count > 0)
            {
                if(curr != null)
                {
                    stack.Push(curr);
                    curr = curr.Left;
                }
                else
                {
                    curr = stack.Pop();
                    Console.Write(curr.Data + " ");
                    curr = curr.Right;
                }
            }
        }

        public void PrintPostorder(TreeNode<int> root)
        {
            if (root == null)
            {
                return;
            }

            var s1 = new Stack<TreeNode<int>>();
            var s2 = new Stack<TreeNode<int>>();

            s1.Push(root);

            while(s1.Count > 0)
            {
                var node = s1.Pop();
                s2.Push(node);
                
                if(node.Left != node)
                {
                    s1.Push(node.Left);
                }

                if(node.Right != null)
                {
                    s1.Push(node.Right);
                }
            }

            while(s2.Count > 0)
            {
                Console.WriteLine(s2.Pop().Data + " ");
            }
        }
    }
}
