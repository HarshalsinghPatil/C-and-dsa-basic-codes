using _1.SimpleQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        SimpleQueue q = null;
        int size;
        int choice;
        int element;

        Console.WriteLine("Enter the size of Array");
        size = int.Parse(Console.ReadLine());
        q = new SimpleQueue(size);

        do
        {
            Console.WriteLine("\n1. Enqueue\n2. Dequeue\n3. Element at Front\n4. Element at Rear\n5. Print Queue Data\n0. Exit\n: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {

                case 1:
                    if(!q.IsFull())
                    {
                        Console.WriteLine("To enter the element");
                        element = int.Parse(Console.ReadLine());
                        q.Enqueue(element);
                    }
                    else
                    {
                        Console.WriteLine("Queue is full ");
                    }
                    break;

                case 2:
                    if (!q.IsEmpty())
                    {

                        Console.WriteLine("Element popped : " + q.Dequeue());
                    }
                    else
                    {
                        Console.WriteLine("Queue is Empty ");
                    }

                    break;

                case 3:
                    if (!q.IsEmpty())
                    {

                        Console.WriteLine("Element at Front : " + q.ElementAtFront());
                    }
                    else
                    {
                        Console.WriteLine("Queue is Empty ");
                    }

                    break;

                case 4:

                    if (!q.IsEmpty())
                    {

                        Console.WriteLine("Element at Rear : " + q.ElementAtRear());
                    }
                    else
                    {
                        Console.WriteLine("Queue is Empty ");
                    }
                    break;

                case 5:
                    q.PrintAll();
                    break;

                case 0:
                    Console.WriteLine("Wait .... Program exiting");
                    break;

                default:

                    Console.WriteLine("Please enter the right choice ");
                    break;

            }

        } while (choice != 0);

    }

}
