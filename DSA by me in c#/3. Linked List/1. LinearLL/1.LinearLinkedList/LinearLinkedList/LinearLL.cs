using System;
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

        public void InsertRight(int data)
        {
            Node newNode = new Node(data);
            if (root == null)
            {
                root = newNode; // If the list is empty, make the new node the root
            }
            else
            {
                Node temp = root;
                while (temp.Next != null)
                {
                    temp = temp.Next; // Move to the last node
                }
                temp.Next = newNode; // Link the last node to the new node
            }
        }

        public void DeleteRight()
        {
            /* 
                Generally in amar panchal codes t1 and t2 are used but for my convenience
                I kept t1 = temp and left = t2
            */
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
            if (root == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                temp = root;
                // Find the node with the specified key
                while (temp != null && temp.Data != key)
                {
                    temp = temp.Next;
                }

                if (temp == null)
                {
                    Console.WriteLine("Key not found");
                }
                else if (temp.Next == null)
                {
                    Console.WriteLine("No node exists after the key node");
                }
                else
                {
                    // Delete the node after the key node
                    Node nodeToDelete = temp.Next;
                    temp.Next = nodeToDelete.Next;
                    Console.WriteLine("Node after key " + key + " deleted, which had data: " + nodeToDelete.Data);
                }
            }
        }


        public void DeleteKeyBased(int key)
        {
            if (root == null)
            {
                Console.WriteLine("List is empty");
            }
            else if (root.Data == key) // If the node to be deleted is the root node
            {
                Console.WriteLine("Node with key " + key + " deleted (was root)");
                root = root.Next; // Move the root to the next node
            }
            else
            {
                // Initialize temp to traverse the list and left to keep track of the previous node
                temp = root;
                Node left = null;

                // Traverse the list to find the node with the specified key
                while (temp != null && temp.Data != key)
                {
                    left = temp;       // Save current node as previous node
                    temp = temp.Next;  // Move to the next node
                }

                if (temp == null) // Key was not found
                {
                    Console.WriteLine("Key not found in the list");
                }
                else // Key is found, delete the node
                {
                    left.Next = temp.Next;
                    Console.WriteLine("Node with key " + key + " deleted");
                }
            }
        }


        
    }
}
