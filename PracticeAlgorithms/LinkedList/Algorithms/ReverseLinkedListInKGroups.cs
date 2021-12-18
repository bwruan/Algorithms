using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //given linked list and a # k
    //reverse list for every k nodes
    public class ReverseLinkedListInKGroups
    {
        public Node<int> ReverseKGroup(Node<int> head, int k)
        {
            if(head == null)
            {
                return null;
            }

            Node<int> curr = head;
            Node<int> next = null;
            Node<int> prev = null;

            var count = 0;

            while(count < k && curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
                count++;
            }

            if(next != null)
            {
                head.Next = ReverseKGroup(next, k);
            }

            return prev;
        }
    }
}
