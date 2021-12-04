using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //link list may contain loop
    //if contain, break it
    public class DetectRemoveLoopLList
    {
        public Node<int> FindRemoveLoop(Node<int> head)
        {
            Node<int> slow = head;
            Node<int> fast = head;

            if(head == null || head.next == null)
            {
                return null;
            }

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    break;
                }
            }

            if(slow == fast)
            {
                slow = head;
                while(slow.next != fast.next)
                {
                    slow = slow.next;
                    fast = fast.next;
                }

                fast.next = null;
            }

            return head;
        }
    }
}
