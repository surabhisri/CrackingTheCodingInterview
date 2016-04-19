/*  Program: Singly Linked List Duplicates Removal
*
*   Author: Surabhi Srivastava
*   
*   Date: 18 Apr 2016
*/

using System;
using System.Linq;

namespace LinkedList
{
    /* Class for linked list */
    public class LinkedList
    {
        /* Class containing linked list node */
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

        /* Last Node */
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

        /* Insert Node at the end */
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

        /* Traverse Node */
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


        /* Function to remove duplicates from the linked list */
        public void DuplicateRemoval()
        {
            Node prev = root;
            Node current = prev.Next;

            while (current != null)
            {
                Node runner = root;
                while (runner != current && runner != null)
                {
                    if (runner.data == current.data)
                    {
                        Node tmp = current.Next;
                        prev.Next = tmp;
                        current = tmp;
                        break;
                    }

                    runner = runner.Next;
                }
                if (runner == current)
                {
                    prev = current;
                    current = current.Next;
                }
            }
        }

        /* Class to test all the Methods of LinkedList class */
        internal class LinkedListTest
        {
            public static void Main()
            {
                LinkedList lt = new LinkedList(); // Create object

                Node n1 = new Node(10);           // Create Node 
                lt.InsertNode(n1);                // Insert Node

                Node n2 = new Node(11);
                lt.InsertNode(n2);

                Node n3 = new Node(12);
                lt.InsertNode(n3);

                Node n4 = new Node(13);
                lt.InsertNode(n4);

                Node n5 = new Node(11);
                lt.InsertNode(n5);

                Node n6 = new Node(10);
                lt.InsertNode(n6);

                Console.WriteLine("List:");
                lt.Traverse();                       //Traverse Linked List

                // Remove duplicates
                lt.DuplicateRemoval();               // Remove Duplicates
                Console.WriteLine("After removal new list:");
                lt.Traverse();

                Console.ReadLine();
            }
        }
    }
}