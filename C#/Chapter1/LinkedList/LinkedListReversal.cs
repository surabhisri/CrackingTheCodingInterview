using System;
using System.Linq;

namespace LinkedList
{
    public class LinkedList
    {
        public class Node
        {
            public Node Next = null;
            public int data;

            public Node(int d)
            {
                data = d;
                Next = null;
            }
        }

        public Node root = null;

        public Node Last
        {
            get
            {
                Node last = root;
                if (root == null)
                {
                    last = null;
                }
                else
                {
                    while (last.Next != null)
                    {
                        last = last.Next;
                    }
                }
                return last;
            }
        }

        public void InsertNode(Node n)
        {
            //Node n = new Node;
            if (root == null)
            {
                root = n;
                root.Next = null;
            }

            else
            {
                n.Next = null;
                Last.Next = n;
            }
        }

        public void Traverse()
        {
            Node curr = root;
            if (curr != null)
            {
                while (curr != null)
                {
                    Console.WriteLine("{0}\t", curr.data);
                    curr = curr.Next;
                }
            }
        }

        public void LinkedListReversal()
        {
            Node prev = null;
            Node curr = root;

            while (curr != null)
            {
                Node nextt = curr.Next;              
                curr.Next = prev;
                prev = curr;
                curr = nextt;
            }
            root = prev;
            //return root;
        }

        internal class LinkedListTest
        {
            public static void Main()
            {
                LinkedList lt = new LinkedList();

                Node n1 = new Node(10);            
                lt.InsertNode(n1);

                Node n2 = new Node(11);
                lt.InsertNode(n2);

                Node n3 = new Node(12);
                lt.InsertNode(n3);

                Node n4 = new Node(13);
                lt.InsertNode(n4);

                Node n5 = new Node(14);
                lt.InsertNode(n5);

                Node n6 = new Node(15);
                lt.InsertNode(n6);

                Console.WriteLine("List:");
                lt.Traverse();
                lt.LinkedListReversal();
                Console.WriteLine("new list:");
                lt.Traverse();
                Console.ReadLine();
            }
        }

    }



}