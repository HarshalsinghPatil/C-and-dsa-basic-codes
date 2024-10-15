using DynamicQueue;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int ch, e;
        DynQueue obj = new DynQueue();
        
       
        do
        {
            Console.WriteLine("1.Enqueue\n2.Dequeue\n3.Print\n0.exit");
            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter Data:");
                    e = int.Parse(Console.ReadLine()); 
                    obj.Enqueue(e);
                    Console.WriteLine("Enqueued");
                    break;

                case 2:
                    obj.Dequeue();
                    break;

                case 3:
                    obj.printQueue();
                    break;

                case 0:
                    Console.WriteLine("Exiting ");
                    break;

                default:
                    Console.WriteLine("Wrong option selected");
                    break;
            }
        } while (ch != 0);
    }
}

