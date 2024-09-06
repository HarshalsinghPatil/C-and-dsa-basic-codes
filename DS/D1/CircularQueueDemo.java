/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author amart
 */
public class CircularQueueDemo 
{
 int front,rear,MaxSize,q[],count;
     
     void createQueue(int size)
     {
         front=0;
         rear=-1;
         count=0;
         MaxSize=size;
         q=new int[MaxSize];
     }
      void enqueue(int e)
      {
          rear=(rear+1)%MaxSize;
          count++;
          q[rear]=e;
          //q[++rear]=e
      }
  
  boolean isFull()
  {
      if(count==MaxSize)
          return true;
      else
          return false;
  }
  int dequeue()
  {
      int temp=q[front];
      front=(front+1)%MaxSize;
      count--;
      return(temp);
  }
  boolean isEmpty()
  {
      if(count==0)
          return true;
      else
          return false;
  }
  
  void printQueue()
  {
     int c=0,i=front;
     while(c<count)
     {
          System.out.println(q[i]);
          i=(i+1)%MaxSize;
          c++;
     }
  }
     
}
