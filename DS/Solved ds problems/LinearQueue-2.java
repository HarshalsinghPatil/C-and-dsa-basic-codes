import java.util.*;

public class LinearQueue
{
	int front,rear,MaxSize,q[];
	void createQueue(int size)
	{
		front = 0;
		rear = -1;
		MaxSize = size;
		q = new int[MaxSize];
	}
	void enqueue(int e){
		rear++ ;
		q[rear] = e;
	}
	boolean isFull()
	{
		if(rear == MaxSize-1)
			return true;
		else
			return false;
	}
	int dequeue(){
		int temp = q[front];
		front++;
		return(temp);
	}
	boolean isEmpty(){
		if(front> rear)
			return true;
		else
			return false;
	}
	void printQueue()
	{
		for(int i = front; i<= rear ;i++)
			System.out.println(q[i]);
	}

public static void main(String args[])
{	
	int ch,e;//
	LinearQueue lq = new LinearQueue();
	Scanner in = new Scanner(System.in);
	System.out.println("Enter the size of Queue:");
	int s = in.nextInt();
	lq.createQueue(s);
	do
	{
		System.out.println("1.enqueue\n2.dequeue\n3.print\n0.exit");
		ch = in.nextInt();
		switch(ch)
		{
			case 1://enque
				if(!lq.isFull())
				{
					System.out.println("Enter Data:");
					e = in.nextInt();
					lq.enqueue(e);
					System.out.println("Element is stored");
				}
				else
					System.out.println("Queue is full");
				break;
			case 2:
				if(!lq.isEmpty())
				{
					e = lq.dequeue();
					System.out.println("Element is removed:");
				}
				else
					System.out.println("Queue is Empty");
			case 3:
				if(!lq.isEmpty())
				{
					System.out.println("Queue contains:");
					lq.printQueue();
				}
				else 
					System.out.println("Queue is Empty:");
				break;
			case 0:
				System.out.println("Exiting");
				break;
			default:
				System.out.println("Wrong option");
				break;
		}
	}while(ch!=0);
}
}


























