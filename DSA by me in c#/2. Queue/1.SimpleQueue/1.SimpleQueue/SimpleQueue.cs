using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _1.SimpleQueue
{
    public  class SimpleQueue
    {
        int[] queue;
        int front;
        int rear;
        int maxSize;
        

        public SimpleQueue (int size)
        {
            maxSize = size;
            front = 0;
            rear = -1;
            queue = new int[maxSize];
        }

        public void Enqueue (int element )
        {
            ++rear;
            queue[rear] = element;
        }

        public int Dequeue ()
        {
            return queue[front++];
        }

        public int ElementAtFront ()
        {
            return queue[front];
        }

        public int ElementAtRear()
        {
            return queue[rear];
        }

        public void PrintAll()
        {
            int index = 0;
            for (int i = 0; i < queue.Length; i++)
            {
                Console.WriteLine($"The value of Queue at index queue[{index}] is {queue[i]}");
                index++;
            }
        }
        public bool IsFull()
        {
            return rear == maxSize - 1;
        }

        public bool IsEmpty()
        {
            return front > rear;
        }




    }
}
