using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicStack
{
    public class DynStack
    {
        Node root, left, temp, temp2;

        public DynStack()
        {
            root = null;
        }


        public void Insert_Left (int data)// push
        {
            Node newNode = new Node(data);

            if(root ==  null)
            {
                root = newNode;
                Console.WriteLine($"element added to the stack succesfully : {root.Data}");
                    
            }
            else
            {
                newNode.Next = root;
                root = newNode;
                Console.WriteLine($"element added to the stack succesfully : {root.Data}");
            }
        }

        public void Delete_left()//pop
        {
            if (root == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                temp = root.Next;
                Console.WriteLine($"Popped element is : {temp.Data}");
                root = temp;
                // root = root.Next; // Only this one line of code is required 

            }
        }

        public void ElementAtTheTop ()//pop
        {
            if (root == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                 Console.WriteLine($"Element at the top is : {root.Data}");
               
            }
        }


        public void PrintNodes ()
        {
            temp = temp2 = root ;
            if(root == null)
            {
                Console.WriteLine("Stack is empty");
            }else {
                // this count temp2 etc I have done just to print the index in reverse way
                int count = 0;
                while (temp2 != null)
                {
                    temp2 = temp2.Next;
                    count++;
                }
                Console.WriteLine("Count : " + count);
                int index = count -1;
                while(temp != null){
                    Console.WriteLine($"node at index [{index}] is {temp.Data}");
                    temp = temp.Next;
                    index--;
                }
            }
        }
    }
}
