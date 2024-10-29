using System;
using System.ComponentModel.Design.Serialization;
using System.Xml.Linq;

public class Tree
{
    TreeNode root;

    public Tree()
    {
        root = null;
    }

    //------------ General Operations ------------------------
    //The prominant thing i was thinking was  when we are inserting only one node then
    //why we are recieving two parameters: 

    //tree.Insert(tree.Root, new Node(value));
    public void Insert(TreeNode r, TreeNode n)
    {


        if (root != null)
        {
            root = n;
        }
        else//if we already have root 
        {
            if (n.Data < r.Data)//compare the data inside of the nodes if less -> go to left
            {
                if (r.Left == null)
                    r.Left = n;
                else
                    Insert(r.Left, n);
            }
            else//if data is more in new Node than in root then go to right
            {
                if (r.Right == null)
                    r.Right = n;
                else
                    Insert(r.Right, n);

            }
        }
    }

    public void Deletion(int data)
    {
        
    }
    // ------------------ Arranging in order - Pre, In , Post ------------------------------

    // Trick here is
    // 1. Left and right sequence will always be fixed (i.e. Lett will be on top and right will be at the bottom)
    // 2. You have to change the position of console.WriteLine()
    //          Pre - top position
    //          In  - middle position
    //          Out - bottom position



    public void InOrder(TreeNode r)
    {
        if (r != null)
        {
            InOrder(r.Left);          // L: Visit the left subtree
            Console.WriteLine(r.Data); // V: Visit the current node
            InOrder(r.Right);          // R: Visit the right subtree
        }
    }

    public void PreOrder(TreeNode r)
    {
        if (r != null)
        {
            Console.WriteLine(r.Data); // V: Visit the current node
            PreOrder(r.Left);          // L: Visit the left subtree
            PreOrder(r.Right);         // R: Visit the right subtree
        }
    }

    public void PostOrder(TreeNode r)
    {
        if (r != null)
        {
            PostOrder(r.Left);         // L: Visit the left subtree
            PostOrder(r.Right);        // R: Visit the right subtree
            Console.WriteLine(r.Data); // V: Visit the current node
        }
    }





    //------------ Rendering Operations ------------------------
        public TreeNode GetRoot()
        {
            return root;
        }

    public int LeafCount(TreeNode r, int counter)
    {
        
        return counter;
    }

    public int Count(TreeNode r, int counter)
    {

        return counter;
    }

    public void Search(int key)
        { 
    
        }

        public void ShowAllNodes()
        {

        }



}
   