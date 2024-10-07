using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;



public class Program
{
    public static void Main(string[] args)
    {
        SimpleStack stack = null;
        int choice, size, element;

        Console.WriteLine("Enter the size of stack ");
        size = int.Parse(Console.ReadLine());
        stack = new SimpleStack(size);

        Console.WriteLine("The size of the stack is : " + size);
        Console.WriteLine("Stack is empty ?" + stack.IsEmpty());
        Console.WriteLine("Stack is full ?" + stack.IsFull());

        do
        {
            Console.WriteLine("Please select from below options \n1. Push\n2. Pop\n3. Element at top\n4. Print Stack Data\n0. Exit\n: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: //push
                    if (!stack.IsFull())
                    {
                        Console.WriteLine("Enter the Element: ");
                        element = int.Parse(Console.ReadLine());
                        stack.Push(element);
                    }
                    else
                    {
                        Console.WriteLine("Can't push , Stack is full ! ");
                    }
                    break;

                case 2: //pop
                    if (!stack.IsEmpty())
                    {
                        Console.WriteLine("The popped element is : " + stack.Pop());
                    }
                    else
                    {
                        Console.WriteLine("Sorry,  Stack is Empty ! ");
                    }
                    break;

                case 3: //peek
                    if (!stack.IsEmpty())
                    {
                        Console.WriteLine("The element at top is : " + stack.ElementAtTop());
                    }
                    else
                    {
                        Console.WriteLine("Sorry,  Stack is Empty ! ");
                    }
                    break;

                case 4: //print all elements
                    if (!stack.IsEmpty())
                    {
                        stack.PrintAll();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, Stack is Empty !");
                    }
                    break;
                case 0: //exit the program 
                    Console.WriteLine("Exiting the program ...!");
                    break;

                default:
                    Console.WriteLine("Wrong Input! Please select valid option");
                    break;

            }

        } while (choice != 0);
    }
}