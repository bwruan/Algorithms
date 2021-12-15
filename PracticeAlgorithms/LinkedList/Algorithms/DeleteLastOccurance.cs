using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //given last occ key, traverse list and keep track of key
    //delete last occ by copying data of next node and deleting next node
    public class DeleteLastOccurance
    {
        public Node<int> DeleteLast(Node<int> head, int x)
        {
            Node<int> curr = head;
            Node<int> ptr = null;

            while(curr != null)
            {
                if(curr.data == x)
                {
                    ptr = curr;
                }

                curr = curr.next;
            }

            if(ptr != null && ptr.next == null)
            {
                curr = head;
                while(curr.next != ptr)
                {
                    curr = curr.next;
                }

                curr.next = null;
            }

            if(ptr != null && ptr.next != null)
            {
                ptr.data = ptr.next.data;
                ptr.next = ptr.next.next;
            }

            return head;
        }
    }
}
