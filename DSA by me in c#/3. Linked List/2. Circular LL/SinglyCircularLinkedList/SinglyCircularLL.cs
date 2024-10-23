using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SinglyCircularLinkedList
{
    public class SinglyCircularLL
    {
        Node root, last, temp;

        public SinglyCircularLL()
        {
            root = last = null;
        }

        public void Insert_Left(int data)
        {
            Node newNode = new Node(data);
            if (root == null)
            {
                root = last = newNode;
                last.Next = root;
                Console.WriteLine("Node inserted from left Succesfully" + root.Data);
            }
            else
            {
                newNode.Next = root;
                root = newNode;
                last.Next = root;
                Console.WriteLine("Node inserted from Left Succesfully" + root.Data);
            }
        }

        public void Delete_Left()
        {
            if(root == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                temp = root.Next;
                root = temp;
                last.Next = root;
            }

        }

        public void Insert_Right()
        {

        }

        public void Delete_Right()
        {

        }

        public void PrintNodes ()
        {

        }

    }
}
