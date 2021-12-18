using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T d)
        {
            Data = d;
            Next = null;
        }
    }
}
