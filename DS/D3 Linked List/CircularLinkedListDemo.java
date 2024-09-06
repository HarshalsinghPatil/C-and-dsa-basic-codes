
public class CircularLinkedListDemo 
{
  Node root,last;
  
 void createLinkedList()
 {
     root=last=null;
 }
         
 void insertLeft(int data)
 {
     Node n=new Node(data);
     if(root==null)
     {
         root=last=n;
         last.next=root;
     }
     else
     {
         n.next=root;
         root=n;
         last.next=root;
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
         if(root.next==root)
         {
             root=last=null;//single node deletion
         }
         else
         {
         root=root.next;
         last.next=root;
         }
         System.out.println("Deleted:"+t.data);
     }
     }
 void insertRight(int data)
 {
     Node n=new Node(data);
     if(root==null)
     {
         root=last=n;
         last.next=root;
     }
     else
     {
        last.next=n;
        last=n;
        last.next=root;
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
         if(root.next==root)
         {
             root=last=null;
         }
         else
         {
            while(t!=last)
            {
                t2=t;
                t=t.next;
            }
            last=t2;
            last.next=root;
         }
         System.out.println("Deleted:"+t.data);
     }
   }
 void printList()
 {
     if(root==null)
     {System.out.println("List Empty");
     }
     else
     {
         Node t;
         t=root;
         do
         {
             System.out.println(t.data);
             t=t.next;
         }  while(t!=root);//2
     }
   }    


   import java.util.Scanner;

   public class Program {
   
   public static void main(String args[])
       {
           int ch;
           CircularLinkedListDemo obj=new  CircularLinkedListDemo();
           Scanner in=new Scanner(System.in);
           obj.createList();
           do
           {
                System.out.println("1.insertLeft\n2.deleteleft\n3.insertright\n4.deleteright\n5.printlist\n0.exit");
                ch=in.nextInt();
                switch(ch)
                {
                    case 1: 
                        System.out.println("Enter data: ");
                        int c=in.nextInt();
                                obj.createLinkedList(c);
                                 break;
                        
                     case 2:
                                obj.deleteLeft();
                                break;
                        
                      case 3:
                          System.out.println("Enter data: ");
                          int b=in.nextInt();
                                 obj.insertRight(b);
                                 break;  
                     
                      case 4:
                                  obj.deleteRight();
                                   break;  
   
                       case 5:
                                   obj.printList();
                                    break;  
   
                                      
                      case 0:
                             System.out.println("Exiting ");
                             break;
                      
                      default:
                             System.out.println("Invalid Option");
                             break;
                }
           }while(ch!=0);
           }
          
   }
}
