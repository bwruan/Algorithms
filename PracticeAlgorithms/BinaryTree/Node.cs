using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Node<T>
    {
        public T data;
        public Node<T> left;
        public Node<T> right;

        public Node(T d)
        {
            data = d;
            left = null;
            right = null;
        }
    }
}
