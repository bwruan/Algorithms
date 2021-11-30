using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //sorted ascending order list
    //delete nodes with duplicate date
    public class RemoveDuplicatesFromSortedLList
    {
        public Node<int> DeleteDuplicates(Node<int> head)
        {
            //initialize pointer to current node
            Node<int> curr = head;

            //if head is null, return null
            if(head == null)
            {
                return null;
            }

            //otherwise, while curr.next is not null
            while(curr.next != null)
            {
                //check if data in current node = next node's data
                //if yes, skip it and set next one more node over
                if(curr.data == curr.next.data)
                {
                    curr.next = curr.next.next;
                }
                else //otherwise, set curr = next node
                {
                    curr = curr.next;
                }
            }

            return head;
        }
    }
}
