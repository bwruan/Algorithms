using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //given L List, rotate CCW by k nodes
    //ex: 10->20->30->40->50->60 k = 4 
    //50->60->10->20->30->40
    public class RotateLList
    {
        public Node<int> RotateList(Node<int> head, int k)
        {
            //return null if there is no list
            if(head == null)
            {
                return null;
            }

            //if k = 0, return head as there will be no rotating
            if(k == 0)
            {
                return head;
            }

            Node<int> curr = head;

            //while next node is not null
            //iterate current pointer to next node
            while(curr.next != null)
            {
                curr = curr.next;
            }

            //reaches end of list (as broken out of loop)
            //set next = head of list and change curr pointer back to head
            //currently a loop in link list as end of list points back to head
            curr.next = head;
            curr = head;

            //iterate through the list until node is < k-1
            for(int i = 0; i < k - 1; i++)
            {
                curr = curr.next;
            }

            //set head = next node and change next to null (aka break loop)
            head = curr.next;
            curr.next = null;

            return head;
        }
    }
}
