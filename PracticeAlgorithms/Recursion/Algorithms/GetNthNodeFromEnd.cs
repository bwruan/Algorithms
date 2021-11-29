using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion.Algorithms
{
    //given linked list and # n, find the nth node from the end of linked list
    public class GetNthNodeFromEnd
    {
        public Node<int> FindNthNodeFromEnd(Node<int> head, int n)
        {
            var count = 0;
            Node<int> slow = head;
            Node<int> fast = head;

            //if head is null, empty list, nothing to return besides null
            if(head == null)
            {
                return null;
            }

            //loop through and iterate count until = n
            while(count < n)
            {
                if(fast == null)
                {
                    Console.WriteLine(n + "is greater than the # of nodes in the list");
                    return null;
                }

                fast = fast.next;
                count++;
            }

            //after breaking out of loop
            //check to see if ref point is null
            //if so, move main pointer to the next node and return
            if(fast == null)
            {
                slow = slow.next;
                return slow;
            }
            else //otherwise, keep looping and moving both pointers to next node, until ref pointer is null; return main pointer
            {
                while(fast != null)
                {
                    slow = slow.next;
                    fast = fast.next;
                }

                return slow;
            }
        }
    }
}
