using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public class SimpleStack
        {// if you want to use public modefier for methods then you need to define class public 

            int[] stack;
            int maxSize;
            int top;
            //int maxSize , top;

            public SimpleStack(int size)
            {
                maxSize = size;
                top = -1;
                stack = new int[maxSize];
            }

            //here in stack methods we have removed all the exceptions becuase it should be handled in program itself
            public void Push(int element)
            {
                ++top;
                stack[top] = element;
            }

            public int Pop()
            {
                return stack[top--];
            }

            public int ElementAtTop()//Peek
            {
                return stack[top];
            }

            public bool IsFull()
            {
                return top == maxSize - 1;
            }

            public bool IsEmpty()
            {
                return top == -1;
            }

            public void PrintAll()
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine($"The element at [{i}] is : {stack[i]}");
                }
            }

        }
    }

/*   Theory */



