import java.util.*;

class Node
{
    int data;
    Node next;
    Node(int data)
    {
        this.data=data;
        next=null;
    }
}
public class LinearLinkedList 
{
  Node root;
  
 void createLinkedList()
 {
     root=null;
 }
         
 void insertLeft(int data)
 {
     Node n=new Node(data);
     if(root==null)
     {
         root=n;
     }
     else
     {
         n.next=root;
         root=n;
     }
   }
 void deleteLeft()
 {    
     if(root==null)
     {
         System.out.println("List Empty");
     }
     else
     {
         Node t=root;
         root=root.next;
         System.out.println("Deleted:"+t.data);
     }
     }
 void insertRight(int data)
 {
     Node n=new Node(data);
     if(root==null)
     {
         root=n;
     }
     else
     {
         Node t=root;
         while(t.next!=null)
         {
             t=t.next;
         }
          t.next=n;
     }
   }
 void deleteRight()
 {
     if(root==null)
     {
         System.out.println("List Empty");
     }
     else
     {
         Node t,t2;
         t=t2=root;
         while(t.next!=null)
         {
             t2=t;
             t=t.next;
         }
         t2.next=null;
         System.out.println("Deleted:"+t.data);
     }
   }
 void printList()
 {
      if(root==null)
     {
         System.out.println("List Empty");
     }
     else
     {
         Node t;
         t=root;
         while(t!=null)
         {
             System.out.println(t.data);
             t=t.next;
         }
         
     }
   }
 void countNodes()
 {
     if(root==null)
     {
         System.out.println("List Empty");
     }
     else
     {
         Node t;
         int c=0;
         t=root;
         while(t!=null)
         {
             
             t=t.next;
             c++;
         }
          System.out.println("Total nodes in list are:"+c);
     }
 }
  
 void searchList(int key)
 {
     if(root==null)
     {
         System.out.println("List Empty");
     }
     else
     {
         Node t;
         int c=0;
         t=root;
         while(t!=null && t.data!=key)
         {
             t=t.next;
             c++;
         }
         if(t!=null)
            System.out.println("Found at "+c+" from root");
         else
             System.out.println("Not Found");
     }
                
}
  void deleteKeybased(int key)
 {
     if(root==null)
     {
         System.out.println("List Empty");
     }
     else
     {
         Node t,t2;
         t=t2=root;
         while(t!=null && t.data!=key)
         {
             t2=t;
             t=t.next;
         }
         if(t==null)
            System.out.println("Not found");
         else
         {
             if(t==root)
             { root=root.next;
             }
           
             else if(t.next==null) 
             {  t2.next=null;
             }
             else
             {  t2.next=t.next;
             }
             
             System.out.println("Deleted:"+t.data);
         }
     }
 }

void insertAfter(int key,int data)
 {
     if(root==null)
     {
         System.out.println("List Empty");
     }
     else
     {
         Node t;
         t=root;
         while(t!=null && t.data!=key)
         {
             t=t.next;
         }
         if(t==null)
            System.out.println("Element Not found");
         else
         {
              Node n=new Node(data);
             n.next=t.next;
             t.next=n;
          }
     }
   }

   public static void main(String args[])
  {
      int ch,e,d;
      LinearLinkedList obj=new  LinearLinkedList();
      Scanner in=new Scanner(System.in);
      obj.createLinkedList();
      do
      {
           System.out.println("1.Insert_Left\n2.Delete_Left\n3.Insert_Right\n4.Delete_Right\n5.Print_List\n6.Count_Nodes\n7.Search_List\n8.Delete_Key\n9.Insert_After\n0.Exit");
           ch=in.nextInt();
           switch(ch)
           {
                case 1:
                           System.out.println("Enter Data To Be Added At Left End:");
                           e=in.nextInt();
                           obj.insertLeft(e);
                           System.out.println("Added Left");
                           break;
                   
                case 2:
                           obj.deleteLeft();
                           break;
                   
                case 3:
                           System.out.println("Enter Data To Be Added At Right End:");
                           e=in.nextInt();
                           obj.insertRight(e);
                           System.out.println("Added Right");
                           break; 
                
                case 4:
                           obj.deleteRight();
                           break;
                
                case 5:
                           obj.printList();
                           break;

                case 6:
                           obj.countNodes();
                           break; 

                case 7:
                           System.out.println("Enter Data To Be Searched:");
                           e=in.nextInt();
                           obj.searchList(e);
                           break;    

                case 8:
                           System.out.println("Enter Data To Be Deleted:");
                           e=in.nextInt();
                           obj.deleteKeybased(e);
                           break;

                case 9:
                           System.out.println("Enter the Key:");
                           e=in.nextInt();
                           System.out.println("Enter the Data to be inserted:");
                           d=in.nextInt();
                           obj.insertAfter(e,d);
                           System.out.println("Data Inserted:"+d);
                           break;
                             
                case 0:
                        System.out.println("Exiting ");
                        break;
                 
                default:
                        System.out.println("Wrong option selected");
                        break;
           }
      }while(ch!=0);

      }

}














