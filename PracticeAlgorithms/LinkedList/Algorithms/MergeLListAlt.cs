using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //2 L list, merge in alt order
    public class MergeLListAlt
    {
        public Node<int> AltMerge(Node<int> h1, Node<int> h2)
        {
            Node<int> curr1 = h1;
            Node<int> curr2 = h2;
            Node<int> next_1 = null;
            Node<int> next_2 = null;

            while(curr1 != null && curr2 != null)
            {
                next_1 = curr1.Next;
                next_2 = curr2.Next;

                curr2.Next = next_1;
                curr1.Next = curr2;

                curr1 = next_1;
                curr2 = next_2;
            }

            return h1;
        }
    }
}
