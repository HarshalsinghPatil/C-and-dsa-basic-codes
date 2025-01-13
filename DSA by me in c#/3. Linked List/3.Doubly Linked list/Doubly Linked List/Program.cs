using Doubly_Linked_List;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        DoublyLinearLL dll = new DoublyLinearLL();
        int e, choice;
        DNode n;

        do
        {
            Console.WriteLine("\n1. Insert to Left\n2. Insert to Right\n3. Delete Left\n4. Delete Right\n5. Print Data\n0. Exit\n: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter element:");
                    e = int.Parse(Console.ReadLine());
                    dll.InsertLeft(e);
                    break;

                case 2:
                    Console.WriteLine("Enter element:");
                    e = int.Parse(Console.ReadLine());
                    dll.InsertRight(e);
                    break;

                case 3:
                    if (!dll.IsEmpty())
                        dll.DeleteLeft();
                    else
                        Console.WriteLine("Sorry, LinkedList is empty");
                    break;

                case 4:
                    if (!dll.IsEmpty())
                         dll.DeleteRight();
                    else
                        Console.WriteLine("Sorry, LinkedList is empty");
                    break;

                case 5:
                    if (!dll.IsEmpty())
                        dll.PrintAll();
                    else
                        Console.WriteLine("Sorry, LinkedList is empty");
                    break;

                case 0:
                    Console.WriteLine("Exiting program");
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        } while (choice != 0);
    }
}