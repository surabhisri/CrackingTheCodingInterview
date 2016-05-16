/*  Program: Describe how you could use a single array to implement three stack
*
*   Author: Surabhi Srivastava
*   
*   Date: 16 May 2016
*/
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArray
{
    /// <summary>
    /// Class to hold member which will convert the array into 3 stacks
    /// </summary>
    class StackArray
    {
        /// <summary>
        /// Function which will convert the parsed array into 3 stacks
        /// </summary>
        /// <param name="arr"></param>
        public static void ArrayToStack(int[] arr)
        {
            int n = arr.Length;
            int i;
            Stack st1 = new Stack();
            Stack st2 = new Stack();
            Stack st3 = new Stack();
            for (i=0;i<n/3;i++)
            {
               st1.Push(arr[i]);
            }
            for (i = n / 3; i < 2*n/3; i++)
            {
                st2.Push(arr[i]);
            }
            for(i=2*n/3; i< n; i++)
            {
                st3.Push(arr[i]);
            }
            Console.WriteLine("Stack 1");
            foreach(int num1 in st1)
            {
                Console.WriteLine(num1);
            }
            Console.WriteLine("Stack 2");
            foreach (int num2 in st2)
            {
                Console.WriteLine(num2);
            }
            Console.WriteLine("Stack 3");
            foreach (int num3 in st3)
            {
                Console.WriteLine(num3);
            }
        }
    }
    /* Class to test all the Method StackArray Class */
    class StackArrayTest
    {
        static void Main(string[] args)
        {
            int[] ar = { 6, 7, 9, 0, 7, 8, 5, 4, 6, 2, 1 };
            StackArray.ArrayToStack(ar);
            Console.ReadLine();
        }
    }
}
