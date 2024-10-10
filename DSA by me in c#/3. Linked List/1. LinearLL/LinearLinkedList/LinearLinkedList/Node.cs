using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearLinkedList
{
    public class Node
    {
        public int Data;  // This stores the data in the node
        public Node Next; // This points to the next node in the list

        public Node(int data)
        {
            Data = data;
            Next = null; // When a node is created, it's not linked to any other node
        }



    }
}
