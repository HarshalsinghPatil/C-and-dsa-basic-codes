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
    public void Insert(TreeNode rt , TreeNode newNode)
    {

        if (root != null)
        {
            root = newNode;
        }
        else//if we already have root 
        {
            if (newNode.Data < rt.Data)//compare the data inside of the nodes if less -> go to left
            {
                if (rt.Left == null)//if null ==save as node
                    rt.Left = newNode;
                else// left is not null then shift to left again == recursion
                    Insert(rt.Left, newNode);
            }
            else//if data is more in new Node than in root then go to right
            {
                if (rt.Right == null)
                    rt.Right = newNode;
                else
                    Insert(rt.Right, newNode);

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
        if ( r != null)
        {
            InOrder( r.Left);          // L: Visit the left subtree
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

        public int Count(TreeNode r, int counter)
        {
            if (r != null)
            {
                counter = Count(r.Left, counter);
                counter++;
                counter = Count(r.Right, counter);
            }
            return counter;
        }

        public int LeafCount(TreeNode r, int counter)
    {
        if(r != null)
        {
            counter = LeafCount(r.Left, counter);//recursively check untill leaf node in Left
            
            //Counter will increase only if the above node is leafNode(i.e.Left and right both sides are null)
            if(r.Left == null && r.Right == null)
            {
                counter++;
            }

            counter = LeafCount(r.Right, counter);
        }
        return counter;
    }



    public void Search(int key)
    {
        if (root == null)
        {
            Console.WriteLine("Empty Tree");
        }
        else
        {
            TreeNode t = root;
            while (t != null && t.Data != key)
            {
                if (key < t.Data)
                    t = t.Left;
                else
                    t = t.Right;
            }

            if (t != null)
                Console.WriteLine("Found");
            else
                Console.WriteLine("Not Found");
        }
    }

    public TreeNode Deletion(int key)
    {
        TreeNode p, r, t, c = null;
        if (root == null)
        {
            Console.WriteLine("Empty Tree");
            return null;
        }
        else
        {
            r = root;
            p = r;

            while (r != null && r.Data != key)
            {
                p = r;
                if (key < r.Data)
                    r = r.Left;
                else
                    r = r.Right;
            }

            if (r == null)
            {
                Console.WriteLine("Not Found");
                return null;
            }
            else
            {
                // Case 1: No children
                if (r.Left == null && r.Right == null)
                {
                    if (root == r)
                    {
                        root = null;
                        return r;
                    }
                    else
                    {
                        if (p.Left == r)
                            p.Left = null;
                        else
                            p.Right = null;
                        return r;
                    }
                }

                // Case 2: Only right child
                if (r.Left == null && r.Right != null)
                {
                    if (r == Root)
                    {
                        root = root.Right;
                        return r;
                    }
                    else
                    {
                        if (p.Right == r)
                            p.Right = r.Right;
                        else
                            p.Left = r.Right;
                        return r;
                    }
                }

                // Case 2: Only left child
                if (r.Left != null && r.Right == null)
                {
                    if (r == root)
                    {
                        root = root.Left;
                        return r;
                    }
                    else
                    {
                        if (p.Left == r)
                            p.Left = r.Left;
                        else
                            p.Right = r.Left;
                        return r;
                    }
                }

                // Case 3: Two children
                if (r.Left != null && r.Right != null)
                {
                    if (r == root)
                    {
                        c = root;
                        r = r.Right;
                        t = r;
                        while (r.Left != null)
                        {
                            t = r;
                            r = r.Left;
                        }
                        t.Left = r.Right;
                        r.Left = root.Left;
                        r.Right = root.Right;
                        root = r;
                    }
                    else
                    {
                        c = r;
                        r = r.Right;
                        t = r;
                        while (r.Left != null)
                        {
                            t = r;
                            r = r.Left;
                        }
                        t.Left = r.Right;
                        r.Left = c.Left;
                        r.Right = c.Right;
                        if (p.Left == c)
                            p.Left = r;
                        else
                            p.Right = r;
                    }
                }
            }
        }
        return c;
    }

    public void ShowAllNodes()
        {

        }



}
   