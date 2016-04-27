/*  Program: Implement a function to check if a linked list is a palindrome.
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
        /// Reverse any linked list from the provided starting node
        /// </summary>
        /// <param name="n">Starting node</param>
        /// <returns>First node of reversed linked list</returns>
        public Node LinkedListReverse(Node n)
        {
            Node prev = null;
            Node current = n;
            while (current != null)
            {
                Node nextt = current.Next;
                current.Next = prev;
                prev = current;
                current = nextt;
            }
            return prev;
        }

        /// <summary>
        /// Function to compare equality of two linked list
        /// </summary>
        /// <param name="n1">root node of first list</param>
        /// <param name="n2">root node of another list</param>
        /// <returns>tre/false</returns>
        public bool Compare(Node n1, Node n2)
        {
            bool returnval = true;
            while (n1 != null && n2 != null)
            {
                if (n1.data != n2.data)
                {
                    returnval = false;
                }
                n1 = n1.Next;
                n2 = n2.Next;
            }
            return returnval;
        }

        /// <summary>
        /// Function to check if the linked list is a palindrome or not
        /// </summary>
        /// <returns>true/false</returns>
        public bool IsPalindrome()
        {
            Node slow = root;
            Node fast = root;
            Node prev_slow = root;
            Node middle_node = root;
            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                prev_slow = slow;
                slow = slow.Next;
            }
            if (fast != null)
            {
                middle_node = slow;
                slow = slow.Next;
            }
            prev_slow.Next = null;

            Node new_node = LinkedListReverse(slow);
            if (Compare(root, new_node))
            {
                return true;
            }
            else
            {
                return false;
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

                Node n4 = new Node(12);
                lt.InsertNode(n4);

                Node n5 = new Node(11);
                lt.InsertNode(n5);

                Node n6 = new Node(10);
                lt.InsertNode(n6);

                if (lt.IsPalindrome())
                {
                    Console.WriteLine("This is a palindrome");
                }
                else
                {
                    Console.WriteLine("Not a palindrome");
                }
                
                Console.ReadLine();
            }
        }
    }
}