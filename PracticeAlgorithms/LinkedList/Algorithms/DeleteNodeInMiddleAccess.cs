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
            if(mid.next == null)
            {
                Console.WriteLine("given node is end of list");
            }

            Node<int> curr = mid;
            curr.data = curr.next.data;
            curr.next = curr.next.next;
        }
    }
}
