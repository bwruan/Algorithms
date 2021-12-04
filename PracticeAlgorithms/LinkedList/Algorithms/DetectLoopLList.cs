using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //given L List, check if has loop or not
    public class DetectLoopLList
    {
         public bool DetectLoop(Node<int> head)
        {
            //slow and fast pointer
            Node<int> slow = head;
            Node<int> fast = head;

            //if head is null or there is only 1 node in list, return false
            if(head == null || head.next == null)
            {
                return false;
            }

            //while nodes at fast pointer != null and next node of fast pointer != null
            //keep moving pointers
            //if they match, there is a loop
            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if(slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
