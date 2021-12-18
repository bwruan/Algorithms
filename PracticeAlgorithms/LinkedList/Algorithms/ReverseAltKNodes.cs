using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //reverse every alt k group of nodes
    public class ReverseAltKNodes
    {
        public Node<int> KAltReverse(Node<int> head, int k)
        {
            if (head == null)
            {
                return null;
            }

            Node<int> curr = head;
            Node<int> next = null;
            Node<int> prev = null;

            var count = 0;

            while (count < k && curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
                count++;
            }

            if(head != null)
            {
                head.Next = curr;
            }

            count = 0;
            while(count < k - 1 && curr != null)
            {
                curr = curr.Next;
                count++;
            }

            if(curr != null)
            {
                curr.Next = KAltReverse(curr.Next, k);
            }

            return prev;
        }
    }
}
