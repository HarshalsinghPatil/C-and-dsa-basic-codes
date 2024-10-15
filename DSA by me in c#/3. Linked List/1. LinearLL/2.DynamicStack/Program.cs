using DynamicStack;
using System; 


public class Program
{
    public static void Main(string[] args)
    {

        DynStack list = new DynStack(); // Create a new linear linked list
            
            // Inserting nodes to the left
            Console.WriteLine("Inserting nodes to the left:");
            list.Insert_Left(10);
            list.Insert_Left(20);
            list.Insert_Left(30);
            list.PrintNodes();
            Console.WriteLine();

          

            // Searching for a node

            Console.WriteLine();

            // Deleting node from the left
            Console.WriteLine("Deleting a node from the left:");
            list.Delete_left();
            list.PrintNodes();
            Console.WriteLine();

            
        } 
}







