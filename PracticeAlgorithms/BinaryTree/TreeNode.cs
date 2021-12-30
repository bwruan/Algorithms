using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class TreeNode<T>
    {
        public T Data;
        public TreeNode<T> Left;
        public TreeNode<T> Right;

        public TreeNode(T data, TreeNode<T> left, TreeNode<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
    }
}
