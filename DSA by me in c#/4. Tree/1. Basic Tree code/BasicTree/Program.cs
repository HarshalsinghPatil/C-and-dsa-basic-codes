using System;
using System.Xml.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Tree t = new Tree();
        TreeNode x, r, n;
        int ch, e;

        do
        {
            Console.WriteLine("\n1.INSERT \n2.INORDER \n3.PREORDER \n4.POSTORDER \n5.SEARCH \n6.DELETE \n7.COUNT NODES \n8.COUNT LEAF NODES \n0.EXIT:");
            ch = int.Parse(Console.ReadLine());
            r = t.GetRoot();

            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter number:");
                    e = int.Parse(Console.ReadLine());
                    n = new TreeNode(e);
                    t.Insert(r, n);
                    break;
                case 2:
                    t.InOrder(r);
                    break;
                case 3:
                    t.PreOrder(r);
                    break;
                case 4:
                    t.PostOrder(r);
                    break;
                case 5:
                    Console.WriteLine("Enter Element To Search:");
                    e = int.Parse(Console.ReadLine());
                    t.Search(e);
                    break;
                case 6:
                    Console.WriteLine("Enter Element To Delete:");
                    e = int.Parse(Console.ReadLine());
                    //x = t.Deletion(e);
                    //please change below code after some time
                    x = new TreeNode(e);
                    t.Deletion(e);
                    if (x != null)
                        Console.WriteLine("Deleted:" + x.Data);
                    break;
                case 7:
                    int totalNodes = t.Count(r, 0);
                    Console.WriteLine("Total number of nodes: " + totalNodes);
                    break;
                case 8:
                    int leafNodes = t.LeafCount(r, 0);
                    Console.WriteLine("Total number of leaf nodes: " + leafNodes);
                    break;
                case 0:
                    Console.WriteLine("Exiting");
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        } while (ch != 0);
    }
}
