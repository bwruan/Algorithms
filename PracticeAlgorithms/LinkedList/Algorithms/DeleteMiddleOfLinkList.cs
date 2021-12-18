using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //given linked list, delete middle node
    //e.g. 1->2->3->4->5 = 1->2->4->5
    public class DeleteMiddleOfLinkList
    {
        public Node<int> RemoveMiddleNode(Node<int> head)
        {
            //print null if linked list is null or only has 1 node 
            //removing that one node makes linked list empty
            if (head == null || head.Next == null)
            {
                return null;
            }

            //initialize fast and slow pointers
            //initial pointer to node prior to middle
            Node<int> slow = head;
            Node<int> fast = head;
            Node<int> prev = null;

            //while fast pointer has not reached the end and the next node is not null
            while(fast != null && fast.Next != null)
            {
                //set fast pointer 2 nodes over
                //set prev to be the current slow pointer node
                //set slow pointer node to the next node
                fast = fast.Next.Next;
                prev = slow;
                slow = slow.Next;
            }

            //once finished, set the next node for the prev pointer = the next node of slow pointer
            //essentially removes the middle node
            //as slow is now at the middle now that fast has reached the end of the list
            prev.Next = slow.Next;

            return head;
        }
    }
}
