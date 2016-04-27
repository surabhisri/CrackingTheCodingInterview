/*  Program: You have two numbers represented by a linked list, where each node contains a
*   single digit. The digits are stored in reverse order, such that the Ts digit is at the
*   head of the list. Write a function that adds the two numbers and returns the sum
*   as a linked list.
*   EXAMPLE
*   Input: (7-> 1 -> 6) + (5 -> 9 -> 2).That is, 617 + 295.
*   Output: 2 -> 1 -> 9.That is, 912.
*   FOLLOW UP
*   Suppose the digits are stored in forward order. Repeat the above problem.
*   EXAMPLE
*   Input: (6 -> 1 -> 7) + (2 -> 9 -> 5).That is, 617 + 295.
*   Output: 9 -> 1 -> 2.That is, 912.
*
*   Author: Surabhi Srivastava
*   
*   Date: 26 Apr 2016
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
        /// function to convert linked list data to number
        /// </summary>
        /// <returns>number</returns>
        public int ConvertNum()
        {
            int num = 0;
            int i = 1;
            Node n = root;
            while (n != null)
            {
                if (n.data != null)
                {
                    num += Convert.ToInt32(n.data) * i;
                    i = i * 10;
                }
                n = n.Next;
            }
            return num;
        }

        /// <summary>
        /// function to convert linked list data to number in forward direction
        /// </summary>
        /// <returns>number</returns>
        public int ConvertNumForward()
        {
            int num = 0;
            int i = 10;
            Node n = root;
            while (n != null)
            {
                if (n.data != null)
                {
                    num = (num * i) + Convert.ToInt32(n.data);
                }
                n = n.Next;
            }
            return num;
        }

        public void ConverttoLinkedList(int NumForl3)
        {
            while (NumForl3 > 0)
            {
                Node new1 = new Node(NumForl3 % 10);
                if (root == null)
                {
                    if (root == null)
                    {
                        root = new1;
                        root.Next = null;
                    }
                }
                else
                {
                    new1.Next = root;
                    root = new1;
                }
                NumForl3 /= 10;
            }
        }

        /* Class to test all the Methods of LinkedList class */
        internal class LinkedListTest
        {
            public static void Main()
            {
                //Linked List 1
                LinkedList l1 = new LinkedList();
                Node m1 = new Node(7);
                Node m2 = new Node(1);
                Node m3 = new Node(3);

                l1.InsertNode(m1);
                l1.InsertNode(m2);
                l1.InsertNode(m3);

                //Linked List 2
                LinkedList l2 = new LinkedList();
                Node k1 = new Node(5);
                Node k2 = new Node(9);
                Node k3 = new Node(2);

                l2.InsertNode(k1);
                l2.InsertNode(k2);
                l2.InsertNode(k3);

                Console.WriteLine("Linked List 1:");
                l1.Traverse();

                Console.WriteLine("Linked List 2:");
                l2.Traverse();

                int numl1 = l1.ConvertNum();
                Console.WriteLine("Number 1: {0}", numl1);

                int numl2 = l2.ConvertNum();
                Console.WriteLine("Number 2: {0}", numl2);

                int num3 = numl1 + numl2;
                Console.WriteLine("Sum: {0}", num3);

                LinkedList newlist = new LinkedList();
                while (num3 > 0)
                {
                    Node new1 = new Node(num3 % 10);
                    newlist.InsertNode(new1);
                    num3 /= 10;
                }

                Console.WriteLine("New Linked List");
                newlist.Traverse();


                // Convert in forward direction

                int NumForl1 = l1.ConvertNumForward();
                Console.WriteLine("Number 1: {0}", NumForl1);

                int NumForl2 = l2.ConvertNumForward();
                Console.WriteLine("Number 2: {0}", NumForl2);

                int NumForl3 = NumForl1 + NumForl2;
                Console.WriteLine("Sum: {0}", NumForl3);

                LinkedList newforwardlist = new LinkedList();

                newforwardlist.ConverttoLinkedList(NumForl3);
                
                Console.WriteLine("New Linked List");
                newforwardlist.Traverse();

                Console.ReadLine();
            }
        }
    }
}