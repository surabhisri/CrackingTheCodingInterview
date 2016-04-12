/*	Program: Compress the string by eliminating the repeated characters and placing the counter after each char representing the number of times that charter is getting repeated
*	
*	Author: Surabhi Srivastava
*
*	Date: 11 Apr 2016
*/

using System;
using System.Text;
using System.Runtime;

namespace CrackingTheCodeInterview
{
    /// <summary>
    /// This class has method to Compress the string into char with count of repeatition of that char for e.g. if Input: aabcccccaaa, Output: a2b1c5a3
    /// If the output string is not smaller than the original string then return the original input string 
    /// </summary>
    public class CompressString
    {
        /// <summary>
        /// This function will compress the string into char with count of repeatition of that char for e.g. if Input: aabcccccaaa, Output: a2b1c5a3
        /// If the output string is not smaller than the original string then return the original input string 
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Compresses string or Original String</returns>
        public static string CompressStr(string str)
        {
            char[] charstr = str.ToCharArray();
            StringBuilder newstr = new StringBuilder();
            int j=0, count = 1, i;
            for(i = 0; i<charstr.Length; i++)
            {
                try
                {
                    if (i + 1 < charstr.Length && charstr[i] == charstr[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        newstr.Append(charstr[i]);
                        newstr.Append(count);
                        count = 1;
                    }
                }
                catch
                {

                }
            }
            string charstring = new String(charstr);
            if (newstr.Length >= charstr.Length)
            {
                return charstring;
            }
            else
            {
                return newstr.ToString();
            }
        }
    }

    /// <summary>
    /// This class tests the CompressString class
    /// </summary>
    internal class CompressStringTest
    {
        /// <summary>
        /// Program execution starts here
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string outputstr = CompressString.CompressStr(str);
            Console.WriteLine("New string: {0}", outputstr);
            Console.ReadLine();
        }
    }
}