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

        public TreeNode(T d)
        {
            Data = d;
            Left = null;
            Right = null;
        }
    }
}
