package Collision;



public class Probling {

	int a[],index,MaxSize;
	
	public void createArray(int size) {
		MaxSize = size;
		index=0;
		a = new int[MaxSize];
	}
	
	public void mode_div(int data){
			
		index = data%10;
		
		if(a[index]==0){
			
			a[index]=data;
		}else
		{
			while(a[index]!=0)
			{
				index++;
			}
			a[index]=data;
		}	
	}
	
	 public void printHashTable(){
	   for(int i =0;i<=MaxSize-1;i++)
	   {
		   System.out.println("Index"+i+"=>"+a[i]);
	   }
	//System.out.println("Table Empty");
	   
	 }
	
}
