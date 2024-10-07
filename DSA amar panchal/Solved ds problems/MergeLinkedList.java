package Sorting;

public class MergeLinkedList {
	
	void merge(SortLinkedList a , SortLinkedList b) {
		
		var t = a.root;
		var t2 = b.root;
		
		while(t.next != null) {
			
			 t = t.next ;
		}
		t.next = t2;
		a.sort();
		System.out.println("Sorted List :\n");
		a.printList();
		
	}
	
	public static void main(String[] args) {
		
		var obj = new SortLinkedList();
		var obb = new SortLinkedList();
		var d = new MergeLinkedList();

		
		obj.createLinkedList();
		obj.insertRight(100);
		obj.insertRight(50);
		obj.insertRight(40);
		obj.insertRight(80);
		obj.insertRight(60);
		
		
		obb.createLinkedList();
		obb.insertRight(10);
		obb.insertRight(90);
		obb.insertRight(70);
		obb.insertRight(30);
		obb.insertRight(20);
		
		
		d.merge(obj,obb);
		
		//obj.printList();
		//System.out.println("\n Sorted List\n");
		//obj.sort();
		//obb.printList();

	}

}
