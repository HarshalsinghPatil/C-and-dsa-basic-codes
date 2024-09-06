package Collision;

import java.util.Scanner;

public class Program {

	
	
	public static void main(String[] args) {
		
		 int ch;
		 Probling obj = new Probling();
		 Scanner sc = new Scanner(System.in);
		 System.out.println("Enter size of Array table");
		 int s = sc.nextInt();
		 obj.createArray(s);
		 do
        {
             System.out.println("1.insert\n2.print hashtable\n0.exit");
             ch=sc.nextInt();
             
             switch(ch)
             {
                case 1:
                	      System.out.println("Enter the element of hash table");
                	      int el = sc.nextInt();
                	      obj.mode_div(el);
                	      break;
                	      
                case 2:
                		System.out.println("Printing.....");
                		obj.printHashTable();
                		break;
                case 0:
                	System.out.println("Exiting....");
                
             }
        }while(ch!=0);
		 sc.close();


}
}