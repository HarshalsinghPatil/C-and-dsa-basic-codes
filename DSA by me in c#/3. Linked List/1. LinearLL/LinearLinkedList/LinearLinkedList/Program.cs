using LinearLinkedList;
using System;

class Program
    {
        public static void Main(string[] args)
        {
            LinearLL list = new LinearLL(); // Create a new linear linked list
            
            // Inserting nodes to the left
            Console.WriteLine("Inserting nodes to the left:");
            list.InsertLeft(10);
            list.InsertLeft(20);
            list.InsertLeft(30);
            list.PrintNodes();
            Console.WriteLine();

            // Inserting nodes to the right
            Console.WriteLine("Inserting nodes to the right:");
            list.InsertRight(40);
            list.InsertRight(50);
            list.PrintNodes();
            Console.WriteLine();

            // Counting nodes
            Console.WriteLine("Counting nodes:");
            list.CountNodes();
            Console.WriteLine();

            // Searching for a node
            Console.WriteLine("Searching for key 20:");
            list.SearchList(20);
            Console.WriteLine();

            // Deleting node from the left
            Console.WriteLine("Deleting a node from the left:");
            list.DeleteLeft();
            list.PrintNodes();
            Console.WriteLine();

            // Deleting node from the right
            Console.WriteLine("Deleting a node from the right:");
            list.DeleteRight();
            list.PrintNodes();
            Console.WriteLine();

            // Insert after a key
            Console.WriteLine("Inserting 25 after key 20:");
            list.InsertAfter(25, 20);
            list.PrintNodes();
            Console.WriteLine();

            // Delete after a key
            Console.WriteLine("Deleting after key 20:");
            list.DeleteAfter(20);
            list.PrintNodes();
            Console.WriteLine();
        }
    }

