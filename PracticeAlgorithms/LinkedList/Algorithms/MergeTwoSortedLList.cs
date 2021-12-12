using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //2 linked list, merge in inc order
    public class MergeTwoSortedLList
    {
        public Node<int> SortedMerge(Node<int> h1, Node<int> h2)
        {
            if (h1 == null)
            {
                return h2;
            }

            if (h2 == null)
            {
                return h1;
            }

            if (h1.data < h2.data)
            {
                h1.next = SortedMerge(h1.next, h2);
                return h1;
            }
            else
            {
                h2.next = SortedMerge(h1, h2.next);
                return h2;
            }
        }
    }
}
