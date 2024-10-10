using LinearLinkedList;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create an instance of the linked list
        LinearLL linkedList = new LinearLL();
        linkedList.CreateLinkedList(); // This sets the root to null

        // Step 2: Insert nodes at the start of the list
        Console.WriteLine("Inserting nodes into the linked list...");
        linkedList.InsertLeft(10); // Insert the first node with data 10
        linkedList.InsertLeft(20); // Insert another node with data 20 (at the start)
        linkedList.InsertLeft(30); // Insert another node with data 30 (at the start)

        // Step 3: Display the initial linked list structure
        Console.WriteLine("Initial linked list structure:");
        DisplayList(linkedList);

        // Step 4: Delete the first node (left-most node)
        Console.WriteLine("\nDeleting the left-most node...");
        linkedList.DeleteLeft(); // This will delete the node with data 30

        // Step 5: Display the linked list after deletion
        Console.WriteLine("Linked list structure after deletion:");
        DisplayList(linkedList);
    }

    // Helper function to display the linked list
    static void DisplayList(LinearLL list)
    {
        Node temp = list.root;
        if (temp == null)
        {
            Console.WriteLine("The list is empty.");
        }
        else
        {
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }
    }
}

