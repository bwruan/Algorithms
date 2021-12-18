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

            if (h1.Data < h2.Data)
            {
                h1.Next = SortedMerge(h1.Next, h2);
                return h1;
            }
            else
            {
                h2.Next = SortedMerge(h1, h2.Next);
                return h2;
            }
        }
    }
}
