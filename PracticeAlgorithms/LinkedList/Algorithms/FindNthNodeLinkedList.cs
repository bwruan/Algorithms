using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //given a Linked List, find element at nth node 
    public class FindNthNodeLinkedList
    {
        public Node<int> FindNthNode(Node<int> head, int n)
        {
            //set current variable to equal to head
            Node<int> current = head;

            //traverse the list
            while(current != null)
            {
                //if data at current node equals to the value we want, return the node
                if(current.Data == n)
                {
                    return current;
                }

                //otherwise, set current to the next node
                current = current.Next; 
            }

            //return nukl if value is not found
            return null;
        }
    }
}
