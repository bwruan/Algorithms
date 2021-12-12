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

            while(curr.next != null && count < m)
            {
                curr = curr.next;
                count++;
            }

            if(curr.next == null)
            {
                return head;
            }

            Node<int> t = curr.next;
            for(count = 1; count <= n && t != null; count++)
            {
                Node <int> temp = t;
                t = t.next;
            }

            curr.next = t;
            curr = t;

            return head;
        }
    }
}
