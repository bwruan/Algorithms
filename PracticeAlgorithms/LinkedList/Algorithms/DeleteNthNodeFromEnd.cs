using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //given linked list and # n
    //delete nth node from the end of the list
    public class DeleteNthNodeFromEnd
    {
        public Node<int> RemoveNthNodeFromEnd(Node<int> head, int n)
        {
            //print null if linked list is null or only has 1 node 
            //removing that one node makes linked list empty
            if (head == null || head.next == null)
            {
                return null;
            }

            //initialize fast and slow and prev pointers
            //initial count to keep track of n
            Node<int> slow = head;
            Node<int> fast = head;
            Node<int> prev = null;
            var count = 0;

            //move fast pointer n nodes ahead
            while (count < n)
            {
                if (fast == null)
                {
                    return head;
                }

                fast = fast.next;
                count++;
            }

            //if fast is now null
            //set prev = slow
            //set slow = next node
            if (fast == null)
            {
                return head.next;
            }

            while (fast != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next;
            }

            //set prev's next node = slow's next node (aka skip node slow pointer currently pointing to (aka nth node from end and delete)
            prev.next = slow.next;

            return head;
        }
    }
}
