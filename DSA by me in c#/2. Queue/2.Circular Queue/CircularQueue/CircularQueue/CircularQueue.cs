using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
{
    public class Circular_Queue
    {
        private int[] q;
        private int front;
        private int rear;
        private int count;
        private int maxSize;
        //private int front, rear, maxSize, count;

        public Circular_Queue (int size)
        {
            maxSize = size;
            front = 0;
            count = 0;
            rear = -1;
            q = new int[maxSize];
        }

        public void Enqueue(int element)
        {
            rear = (rear + 1) % maxSize;
            q[rear] = element;
            count++;
        }

        public int Dequeue()
        {
            int item = q[front];
            front = (front + 1) % maxSize;
            count--;
            return item;

        }

        public void PrintAll()// Here printing circular queue is very skill full work 
        {
            int i = front;
            for (int c = 0; c < count; c++)
            {
                Console.WriteLine($"Element at index {i} is {q[i]}");
                i = (i + 1) % maxSize;
            }
        }

        public int ElementAtFront()
        {
            return q[front];
        }

        public int ElementAtRear()
        {
            return q[rear];
        }

        public bool IsFull()
        {
            return count == maxSize;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

       
    }

}
