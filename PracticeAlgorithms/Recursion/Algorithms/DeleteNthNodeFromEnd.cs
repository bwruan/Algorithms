using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion.Algorithms
{
    //given linked list and # n
    //delete nth node from the end of the list
    public class DeleteNthNodeFromEnd
    {
        public void RemoveNthNodeFromEnd(Node<int> head, int n)
        {
            //print null if linked list is null or only has 1 node 
            //removing that one node makes linked list empty
            if (head == null || head.next == null)
            {
                Console.WriteLine("Null");
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
                    Console.WriteLine(n + "is greater than the # of nodes in the list");
                }

                fast = fast.next;
                count++;
            }

            //if fast is now null
            //set prev = slow
            //set slow = next node
            if (fast == null)
            {
                prev = slow;
                slow = slow.next;
            }
            else //otherwise, keep looping and moving all pointers to next node, until fast pointer is null
            {
                while (fast != null)
                {
                    prev = slow;
                    slow = slow.next;
                    fast = fast.next;
                }
            }

            //set prev's next node = slow's next node (aka skip node slow pointer currently pointing to (aka nth node from end and delete)
            prev.next = slow.next;
        }
    }
}
