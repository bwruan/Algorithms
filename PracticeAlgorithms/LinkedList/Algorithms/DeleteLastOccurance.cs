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
                if(curr.Data == x)
                {
                    ptr = curr;
                }

                curr = curr.Next;
            }

            if(ptr != null && ptr.Next == null)
            {
                curr = head;
                while(curr.Next != ptr)
                {
                    curr = curr.Next;
                }

                curr.Next = null;
            }

            if(ptr != null && ptr.Next != null)
            {
                ptr.Data = ptr.Next.Data;
                ptr.Next = ptr.Next.Next;
            }

            return head;
        }
    }
}
