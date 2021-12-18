using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //given 2 singly linked list in which error caused end of 1 to link to 2nd list
    //find intersection point
    public class IntersectionOfTwoLList
    {
        public Node<int> FindIntersection(Node<int> h1, Node<int> h2)
        {
            Node<int> curr1 = h1;
            Node<int> curr2 = h2;

            if(curr1 == null || curr2 == null)
            {
                return null;
            }

            while(curr1 != curr2)
            {
                curr1 = curr1.Next;
                curr2 = curr2.Next;

                if(curr1 == curr2)
                {
                    return curr1;
                }

                if(curr1 == null)
                {
                    curr1 = h2;
                }

                if(curr2 == null)
                {
                    curr2 = h1;
                }
            }

            return curr1;
        }
    }
}
