﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinearLinkedList
{
    public class LinearLL
    {
        public Node root, temp, newNode,left;  // The root (start) of the linked list

        // This creates an empty linked list
        public LinearLL()
        {
            root = null;
        }

        // Insert a new node at the start (left) of the list
        public void InsertLeft(int data)
        {
            Node newNode = new Node(data);
            if (root == null)
            {
                root = newNode; // If list is empty, make the new node the root
            }
            else
            {//Kim: we never take a risk of loosing node=> step 1 store address of root then step 2 declare node at left root
                newNode.Next = root; // Point the new node to the current root
                root = newNode;      // Make the new node the new root
            }
        }

        public void  DeleteLeft()
        {
            if (root == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                temp = root;
                //if we don't want to see the data inside deleted node we don't need to store in temp variable 
                root = root.Next;
                Console.WriteLine("Node deleted " + temp.Data);
            }
        }

        public void InsertRight (int data)
        {
            newNode = new Node(data);
            temp = root ;
            while (temp != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode; 
        }

        public void DeleteRight()
        {
            left = temp = root;
            if(temp == null)
            {
                Console.WriteLine("List is not empty");
            }
            else
            {
                while (temp != null)
                {
                    left = temp;
                    temp = temp.Next;
                }
                left.Next = null;
            }

        }

        public void PrintNodes()
        {
            temp = root;
            if (root == null)
            {
                Console.WriteLine("Sorry List is Empty");
            }
            else
            {
                int index = 0;
                while (temp != null)
                {
                    Console.WriteLine($"The data at the index {index} is {temp.Data}");
                    temp = temp.Next;
                    index++;
                }
            }
        }

        public void CountNodes()
        {
            temp = root;
            if (root == null)
            {
                Console.WriteLine("Sorry List is Empty");
            }
            else
            {
                int count = 0;
                while (temp != null)
                {
                    temp = temp.Next;
                    count++;
                }

                Console.WriteLine($"The total number of nodes are {count} ");

            }
        }

        public void SearchList(int key)
        {
            if (root == null)
            {
                newNode = root;
            }
            else
            {
                temp = root;
                int position = 0;
                while (temp != null && temp.Data == key)
                {
                    temp = temp.Next;
                    position++;
                }
                if (temp == null)
                {
                    Console.WriteLine("Key not found ");
                }
                else 
                {
                    Console.WriteLine("Key found at position : "+ position);
                }
            }
        }

        public void InsertAfter(int data, int key)
        {
            newNode = new Node(data);

            if (root == null)
            {
                newNode = root;
            }
            else
            {
                temp = left = root;
                while (temp != null && temp.Data == key)
                {
                    left = temp;
                    temp = temp.Next;
                }
                if (temp == null)
                {
                    Console.WriteLine("Key not found ");
                }
                else
                {
                    newNode.Next = temp;
                    left.Next = newNode;
                }
            }
        }

        public void DeleteAfter(int key)
        {
            int position = 0;

            if (root == null)
            {
                newNode = root;
            }
            else
            {
                temp = left = root;
                while (temp != null && temp.Data == key)
                {
                    left = temp;
                    temp = temp.Next;
                    position++;
                }
                if (temp == null)
                {
                    Console.WriteLine("Key not found ");
                }
                else
                {
                    if (temp == root)//at start
                    {
                        root = null;
                    }
                    else if (temp.Next == null)//at end 
                    {
                        left.Next = null;
                    }
                    else //in between 
                    {

                        left.Next = temp.Next;
                    }
                }
            }
        }
        
    }
}
