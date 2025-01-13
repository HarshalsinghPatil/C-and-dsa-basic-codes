using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    public class DoublyLinearLL
    {
        public DNode root, temp , LeftNode ;

        public DoublyLinearLL()
        {
            root = null;
        }

        public void InsertLeft (int data)
        {
            DNode newNode = new DNode(data);
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                newNode.Next = root;
                root.Prev = newNode;
                root = newNode;
                Console.WriteLine($"Node inserted at left of linked list");
            }
        }


        public void InsertRight(int data)
        {
            DNode newNode = new DNode(data);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                temp = root;
                while(temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Prev = temp;
            }

        }

        public void DeleteLeft ()
        {
            if (root == null)
            {
                Console.WriteLine($"List is Empty");
            }
            else
            {
                temp = root;
                root = root.Next;
                if (root != null) // Check to avoid null reference when list is emptied
                    root.Prev = null;
                Console.WriteLine("Element removed is " + temp.Data);
            }

        }

        public void DeleteRight ()
        {
            if(root == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                temp = root;
                while(temp.Next != null)
                {
                    temp = temp.Next;  
                }
                LeftNode = temp.Prev;

                if (LeftNode != null) // Check to avoid null reference when there's only one node
                    LeftNode.Next = null;
                else
                    root = null; // If the list is emptied, reset root

            }
        }

        public void PrintAll()
        {
            temp = root;
            while (temp != null)
            {
                Console.Write("<-| " + temp.Data + " |-> ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public bool IsEmpty()
        {
            return root == null;
        }

    }
}
