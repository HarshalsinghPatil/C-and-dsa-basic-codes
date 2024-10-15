using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQueue
{
    public class DynQueue
    {
        Node front, rear;

        public DynQueue()
        {
            front = rear = null;
        }

        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue Empty");
            }
            else
            {
                Node t = front;//1
                front = front.Next;//2
                Console.WriteLine("Dequeued:" + t.Data);
            }
        }

        public void Enqueue(int Data)
        {
            Node n = new Node(Data);
            if (front == null)
            {
                front = rear = n;
            }
            else
            {
                rear.Next = n;
                rear = n;
            }
        }

        public void printQueue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue Empty");
            }
            else
            {
                Node t;
                t = front;
                while (t != null)//2
                {
                    Console.WriteLine(t.Data);
                    t = t.Next;
                }

            }
        }
    }

}

