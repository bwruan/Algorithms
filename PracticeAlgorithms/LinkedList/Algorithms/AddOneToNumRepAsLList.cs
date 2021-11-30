using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //given a # represented as L List
    //add 1 to it
    //ex: 1999 => 1->9->9->9 + 1 = 2->0->0->0
    public class AddOneToNumRepAsLList
    {
        public Node<int> AddOne(Node<int> head)
        {
            //initialize variable with reverse linked list method
            var reverse = new ReverseLinkedList();

            //reverse the list
            reverse.ReverseList(head);

            //initialize and set carry = 1 for adding
            //initialize sum and current pointer 
            var carry = 1;
            var sum = 0;
            Node<int> curr = head;

            //while current pointer is not null
            //sum = data at current node + carry (aka 1)
            //check if sum >=10 if so, set carry = 1, otherwise set = 0
            //set data at current node = sum
            //move curr to next node
            while(curr != null)
            {
                sum = curr.data + carry;

                if(sum >= 10)
                {
                    carry = 1;
                    sum = sum % 10;
                }
                else
                {
                    carry = 0;
                }

                curr.data = sum;

                curr = curr.next;
            }
            
            //if carry still has a non-zero value
            //make new node with carry val as data
            //set current (which should be null) = new node
            if(carry > 0)
            {
                Node<int> newNode = new Node<int>(carry);

                curr = newNode;
            }

            //re-reverse the list
            reverse.ReverseList(head);

            return head;
        }
    }
}
