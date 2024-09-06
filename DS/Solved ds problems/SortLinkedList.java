package Sorting;

//import java.util.Scanner;
class Node {
	int data;
	Node next;

	Node(int data) {
		this.data = data;
		next = null;
	}
}

public class SortLinkedList {

	Node root;

	void createLinkedList() {
		root = null;
	}

	void insertRight(int data) {
		Node n = new Node(data);
		if (root == null) {
			root = n;
		} else {
			Node t = root;// 1 use t to search right
			while (t.next != null)// 2
			{
				t = t.next;
			}
			t.next = n;// 3
		}
	}

	void sort() {
		Node t, t2;

		t = t2 = root;
		while (t.next != null) {
			t2 = t;
			t = t.next;
			if (t.data < t2.data) {
				var temp = t.data;
				t.data = t2.data;
				t2.data = temp;
				sort();
			}
		}
	}

	void printList() {
		if (root == null) {
			System.out.println("List Empty");
		} else {
			Node t;
			t = root;
			while (t != null)// 2
			{
				System.out.println(t.data);
				t = t.next;
			}

		}
	}

	public static void main(String[] args) {

		var obj = new SortLinkedList();
		// Scanner in = new Scanner(System.in);

		obj.createLinkedList();
		obj.insertRight(20);
		obj.insertRight(50);
		obj.insertRight(40);
		obj.insertRight(80);
		obj.insertRight(40);
		obj.insertRight(30);
		obj.printList();
		System.out.println("\n Sorted List\n");
		obj.sort();
		obj.printList();

	}

}
