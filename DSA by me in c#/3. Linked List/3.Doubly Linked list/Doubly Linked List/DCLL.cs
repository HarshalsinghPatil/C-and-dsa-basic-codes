using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Doubly_Linked_List
{
    public class DCLL
    {
        private DNode root, last, temp, left;

        public DCLL()
        {
            root = last = null;
        }

        // Insert at the beginning
        public void InsertLeft(int data)
        {
            DNode newNode = new DNode(data);
            if (root == null)
            {
                root = last = newNode;
                root.Next = root;
                root.Prev = root;
            }
            else
            {
                newNode.Next = root;
                newNode.Prev = last;
                root.Prev = newNode;
                last.Next = newNode;
                root = newNode;
            }
        }

        // Insert at the end
        public void InsertRight(int data)
        {
            DNode newNode = new DNode(data);
            if (root == null)
            {
                root = last = newNode;
                root.Next = root;
                root.Prev = root;
            }
            else
            {
                newNode.Prev = last;
                newNode.Next = root;
                last.Next = newNode;
                root.Prev = newNode;
                last = newNode;
            }
        }

        // Delete from the beginning
        public DNode DeleteLeft()
        {
            if (root == null)
            {
                return null;
            }
            else if (root == last)
            { // Only one element
                temp = root;
                root = last = null;
            }
            else
            {
                temp = root;
                root = root.Next;
                root.Prev = last;
                last.Next = root;
            }
            return temp;
        }

        // Delete from the end
        public DNode DeleteRight()
        {
            if (root == null)
            {
                return null;
            }
            else if (root == last)
            { // Only one element
                temp = last;
                root = last = null;
            }
            else
            {
                temp = last;
                last = last.Prev;
                last.Next = root;
                root.Prev = last;
            }
            return temp;
        }

        // Print all nodes
        public void PrintAll()
        {
            if (root == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            temp = root;
            do
            {
                Console.Write("<-| " + temp.Data + " |-> ");
                temp = temp.Next;
            } while (temp != root);
            Console.WriteLine();
        }

        // Check if the list is empty
        public bool IsEmpty()
        {
            return root == null;
        }
    }
}
