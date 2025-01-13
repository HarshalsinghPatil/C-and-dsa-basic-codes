using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    public class ProgramDCLL
    {
        static void Main1(string[] args)
        {
            DCLL list = new DCLL();
            int choice;

            do
            {
                Console.WriteLine("\n1. Insert to Left\n2. Insert to Right\n3. Delete Left\n4. Delete Right\n5. Print Data\n0. Exit\n: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter element:");
                        int eLeft = int.Parse(Console.ReadLine());
                        list.InsertLeft(eLeft);
                        break;
                    case 2:
                        Console.WriteLine("Enter element:");
                        int eRight = int.Parse(Console.ReadLine());
                        list.InsertRight(eRight);
                        break;
                    case 3:
                        if (!list.IsEmpty())
                        {
                            Console.WriteLine("Element removed is " + list.DeleteLeft().Data);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, LinkedList is empty");
                        }
                        break;
                    case 4:
                        if (!list.IsEmpty())
                        {
                            Console.WriteLine("Element removed is " + list.DeleteRight().Data);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, LinkedList is empty");
                        }
                        break;
                    case 5:
                        if (!list.IsEmpty())
                        {
                            list.PrintAll();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, LinkedList is empty");
                        }
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
}
