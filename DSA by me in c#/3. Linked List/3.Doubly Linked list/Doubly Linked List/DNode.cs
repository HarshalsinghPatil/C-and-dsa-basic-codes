using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    public class DNode
    {
        public int Data;
        public DNode Prev, Next;

        public DNode(int data) 
        { 
            Data = data;
            Prev = Next = null;
        }

    }
}
