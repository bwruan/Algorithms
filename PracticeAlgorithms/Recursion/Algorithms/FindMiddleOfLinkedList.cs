using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion.Algorithms
{
    //given list, find middle node
    //if even list, 2 middles, print 2nd middle
    public class FindMiddleOfLinkedList
    {
        public void FindMiddleNode(Node<int> head)
        {
            //create two pointer node, slow and fast
            Node<int> slow = head;
            Node<int> fast = head;

            //if Linked list is not empty
            if(head != null)
            {
                //while fast pointer is not null and there is a next node
                while(fast != null && fast.next != null)
                {
                    //move fast pointer by 2 and slow pointer by 1
                    //slow will be at middle when fast reaches end of list
                    fast = fast.next.next;
                    slow = slow.next;
                }

                Console.WriteLine("Middle node is " + slow);
            }
        }
    }
}
