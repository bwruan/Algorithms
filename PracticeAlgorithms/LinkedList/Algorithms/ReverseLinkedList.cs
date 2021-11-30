using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion.Algorithms
{
    //given head node of Linked List, reverse list
    public class ReverseLinkedList
    {
        public Node<int> ReverseList(Node<int> head)
        {
            //initiate current, prev. and next nodes
            Node<int> curr = head;
            Node<int> prev = null;
            Node<int> next = null;

            //iterate through the list
            //set next as the curr.next node
            //set next node as prev node
            //set prev as curr node
            //set curr as the next node
            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            
            //after reaching the end, set head as prev node (which should have been the final node in the original list)
            head = prev;

            return head;
        }
    }
}
