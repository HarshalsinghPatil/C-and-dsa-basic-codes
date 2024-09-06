import java.util.*;

class Node1 {
	int coefficient;
	int power;
	Node1 next;
	
	public Node1 (int data, int degree) {
		coefficient = data;
		power = degree;
		next = null;
	}
}

public class PolynomialList{
	Scanner sc = new Scanner(System.in);
	Node1 root = null;
	void createList(int degree){
		
		for (int i = degree; i>=0 ; --i){
			System.out.println("Enter the Coefficient for x^"+i);
			int data = sc.nextInt();
			Node1 n =new Node1(data, i );
			 if(root==null)
		     {
		         root=n;
		     }
		     else
		     {
		         Node1 t=root;
		         while(t.next!=null)
		         {
		             t=t.next;
		         }
		          t.next=n;
		     }
			
		}
	
	}
	
	void print() {
		 if(root==null)
	     {
	         System.out.println("List Empty");
	     }
	     else
	     {
	         Node1 t;
	         t=root;
	         while(t!=null)
	         {
	             System.out.println(t.coefficient+"x^"+t.power);
	             t=t.next;
	         }
	     }
	}
 
void addList(PolynomialList obj) {
	var t= this.root;
	var t2 = obj.root;
	while(t!=null&& t2!=null) {
		if(t.power==t2.power)
			t.coefficient+=t2.coefficient;
		t=t.next;
		t2=t2.next;
	}
	print();
	sc.close();
}
void subList(PolynomialList obj) {
	var t= this.root;
	var t2 = obj.root;
	while(t!=null&& t2!=null) {
		if(t.power==t2.power)
			t.coefficient-=t2.coefficient;
		t=t.next;
		t2=t2.next;
	}
	print();
	sc.close();
}

public static void main(String[] args) {
	Scanner scan = new Scanner(System.in);
	System.out.println("Enter the degree of Polynomial:");
	int a = scan.nextInt();
	
	var obj = new PolynomialList();
	obj.createList(a);
	obj.print();
	
	var obj2 = new PolynomialList();
	obj2.createList(a);
	obj2.print();

	
	System.out.println("=========================");
	
	obj.addList(obj2);		

	scan.close();

}
}