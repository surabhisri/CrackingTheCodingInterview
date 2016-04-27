/*  Program: Given a circular linked list, implement an algorithm which returns the node at
*   the beginning of the loop.
*   DEFINITION
*   Circular linked list: A (corrupt) linked list in which a node's next pointer points
*   to an earlier node, so as to make a loop in the linked list.
*   EXAMPLE
*   Input: A - > B - > C - > D - > E - > C [the same C as earlier]
*   Output: C
*
*   Author: Surabhi Srivastava
*   
*   Date: 27 Apr 2016
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
            public int? data;

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
                    if (curr.data != null)
                    {
                        Console.WriteLine("{0}\t", curr.data);
                        curr = curr.Next;
                    }
                }
            }
        }     

        /// <summary>
        /// Function to check whether the linked listr circular or not
        /// </summary>
        /// <returns>true/false</returns>
        public bool IsCircular()
        {
            Node slow = root;
            Node fast = root.Next.Next;
            bool returnval = false;
            while (fast != null && fast.Next.Next != null)
            {
                if (slow == fast)
                {
                    returnval = true;
                    break;
                }
                slow = slow.Next;
                fast = fast.Next.Next;


            }
            if (fast == null || fast.Next.Next == null)
            {
                returnval = false;
            }
            return returnval;
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

                n6.Next = n4;                   //assigning a node next to last node of the list

                if (lt.IsCircular())
                {
                    Console.WriteLine("This linked list is circular");
                }
                else
                {
                    Console.WriteLine("This is not a circular linked list");
                }              
                Console.ReadLine();
            }
        }
    }
}