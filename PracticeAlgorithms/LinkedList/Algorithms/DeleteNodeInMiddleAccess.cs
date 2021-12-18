using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Algorithms
{
    //delete node in middle of list given only access to that node
    public class DeleteNodeInMiddleAccess
    {
        public void DeleteMiddleAccess(Node<int> mid)
        {
            if(mid.Next == null)
            {
                mid = null;
            }

            Node<int> curr = mid;
            curr.Data = curr.Next.Data;
            curr.Next = curr.Next.Next;
        }
    }
}
