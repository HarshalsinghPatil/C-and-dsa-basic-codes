﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQueue
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node (int data)
        {
            Data = data;
            Next = null;
       }
    }
}
