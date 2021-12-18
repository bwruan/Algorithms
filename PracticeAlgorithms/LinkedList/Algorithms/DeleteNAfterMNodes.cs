using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //skip M nodes, delete N nodes
    public class DeleteNAfterMNodes
    {
        public Node<int> SkipMRemoveN(Node<int> head, int m, int n)
        {
            Node<int> curr = head;
            var count = 0;

            while(curr.Next != null && count < m)
            {
                curr = curr.Next;
                count++;
            }

            if(curr.Next == null)
            {
                return head;
            }

            Node<int> t = curr.Next;
            for(count = 1; count <= n && t != null; count++)
            {
                Node <int> temp = t;
                t = t.Next;
            }

            curr.Next = t;
            curr = t;

            return head;
        }
    }
}
