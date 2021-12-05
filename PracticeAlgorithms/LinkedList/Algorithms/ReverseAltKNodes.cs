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
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
                count++;
            }

            if(head != null)
            {
                head.next = curr;
            }

            count = 0;
            while(count < k - 1 && curr != null)
            {
                curr = curr.next;
                count++;
            }

            if(curr != null)
            {
                curr.next = KAltReverse(curr.next, k);
            }

            return prev;
        }
    }
}
