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

            if(head == null || head.Next == null)
            {
                return null;
            }

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    break;
                }
            }

            if(slow == fast)
            {
                slow = head;
                while(slow.Next != fast.Next)
                {
                    slow = slow.Next;
                    fast = fast.Next;
                }

                fast.Next = null;
            }

            return head;
        }
    }
}
