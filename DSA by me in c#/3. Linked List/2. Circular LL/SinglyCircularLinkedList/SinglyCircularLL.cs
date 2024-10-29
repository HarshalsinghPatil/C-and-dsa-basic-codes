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
/*
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

        public void Insert_Right(int data)
        {   
            Node newNode = new Node(data);
            if(root == null)
            {
                root = last = newNode ;
                last.Next = root;
            }
            else//here we know the last node so no need to traverse till the end of list
            {
                last.Next = newNode;
                last = newNode;
                last.Next = root;
            }
        }

        public void Delete_Right()
        {
            left = temp = root;
            if(temp == null)
            {
                Console.WriteLine("List is not empty");
            }
            else
            {
                while (temp != last)
                {
                    left = temp;
                    temp = temp.Next;
                }
                last = left;
                last.Next = root;
            }
        }

        /* SOME OF THE KEY CASES MISSED / MISTAKES  IN ABOVE CODES WRITTEN BY ME
        
        Your code logic for Insert_Left, Delete_Left, Insert_Right, and Delete_Right is mostly correct for a singly circular linked list, but there are a few points to refine for accuracy and robustness. Here’s a breakdown of each method:

        Review of Each Method
        Insert_Left (Inserts a new node at the left/start of the list):
        ----------------------------------------------------------------
        Your code is correct. You set the new node’s Next to the current root and 
        update last.Next to point to the new root, ensuring circular linkage. This 
        method works as intended.

        Delete_Left (Deletes the first node from the left/start):
        ---------------------------------------------------------
        The logic here works, but there’s a case to handle when there’s only one 
        node in the list. If root == last, setting root = temp will break the circular link.
        You should check if root == last and handle it as a special case by setting 
        both root and last to null when deleting the only node in the list.

        Insert_Right (Inserts a new node at the end/right of the list):
        ----------------------------------------------------------------
        This method works well. You directly insert after last, update last, and
         set last.Next to point to root.

        Delete_Right (Deletes the last node from the end/right):
        ---------------------------------------------------------
        This is mostly correct, but it should also handle the case where there is 
        only one node in the list. When root == last, deleting the node should set 
        both root and last to null.
        
        */
 */

            public void Insert_Left(int data)
            {
                Node newNode = new Node(data);
                if (root == null)
                {
                    root = last = newNode;
                    last.Next = root; // Single node points to itself
                    Console.WriteLine("Node inserted from left successfully: " + root.Data);
                }
                else
                {
                    newNode.Next = root; 
                    root = newNode;      
                    last.Next = root;    
                    Console.WriteLine("Node inserted from left successfully: " + root.Data);
                }
            }

            public void Delete_Left()
            {
                if (root == null)
                {
                    Console.WriteLine("List is empty");
                }
                //I have ignored this condition
                else if (root == last) // Only one node in the list
                {
                    Console.WriteLine("Node deleted from left successfully: " + root.Data);
                    root = last = null; // Remove the only node
                }
                else
                {
                    temp = root.Next;   
                    Console.WriteLine("Node deleted from left successfully: " + root.Data);
                    root = temp;        
                    last.Next = root;   
                }
            }

            public void Insert_Right(int data)
            {   
                Node newNode = new Node(data);
                if (root == null)
                {
                    root = last = newNode;
                    last.Next = root; 
                    Console.WriteLine("Node inserted from right successfully: " + root.Data);
                }
                else
                {
                    last.Next = newNode; 
                    last = newNode;      
                    last.Next = root;    
                    Console.WriteLine("Node inserted from right successfully: " + last.Data);
                }
            }

            public void Delete_Right()
            {
                if (root == null)
                {
                    Console.WriteLine("List is empty");
                }
                else if (root == last) // Only one node in the list
                {
                    Console.WriteLine("Node deleted from right successfully: " + root.Data);
                    root = last = null; // Remove the only node
                }
                else
                {
                    left = temp = root;
                    while (temp.Next != root) // Traverse to the last node
                    {
                        left = temp;          // Store the second-last node
                        temp = temp.Next;      // Move to the next node
                    }
                    last = left;             // Second-last becomes the new last
                    last.Next = root;        // New last points to root
                    Console.WriteLine("Node deleted from right successfully: " + temp.Data);
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
                do
                {
                    Console.WriteLine($"The data at index {index} is {temp.Data}");
                    temp = temp.Next;
                    index++;
                }while (temp != root);
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
                do
                {
                    temp = temp.Next;
                    count++;

                }while (temp != root);

                Console.WriteLine($"The total number of nodes are {count} ");

            }
        }

        public void SearchList(int key)
        {
            if (root == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            temp = root;
            int position = 0;
            bool found = false;

            do
            {
                if (temp.Data == key)
                {
                    Console.WriteLine("Key found at position: " + position);
                    found = true;
                    break;
                }
                temp = temp.Next;
                position++;
            } while (temp != root);

            if (!found)
            {
                Console.WriteLine("Key not found");
            }
        }

        public void InsertAfter(int data, int key)
        {
            newNode = new Node(data);

            if (root == null)
            {
                root = newNode;
                root.Next = root; // Points to itself to create circular structure
            }
            else
            {
                temp = root;
                bool found = false;

                do
                {
                    if (temp.Data == key)
                    {
                        found = true;
                        newNode.Next = temp.Next; // newNode points to the next node after temp
                        temp.Next = newNode;       // temp points to the newNode
                        break;
                    }
                    temp = temp.Next;
                } while (temp != root);

                if (!found)
                {
                    Console.WriteLine("Key not found");
                }
            }
        }

        public void DeleteAfter(int key)
        {
            if (root == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            temp = root;
            bool found = false;

            do
            {
                if (temp.Data == key)
                {
                    found = true;

                    if (temp.Next == root) // If the next node is the root, we are at the end
                    {
                        temp.Next = root.Next; // Point current node to the node after root
                        root = root.Next;      // Update root to the next node
                    }
                    else
                    {
                        temp.Next = temp.Next.Next; // Skip the node after the key
                    }
                    break;
                }
                temp = temp.Next;
            } while (temp != root);

            if (!found)
            {
                Console.WriteLine("Key not found");
            }
        }


    }
}
