/*	Program: Replace spaces in an input string with %20 
 *	Author: Surabhi Srivastava
 *	
 *	Date: 9 April, 2016
 */

using System;

namespace CrackingTheCodingInterview
{
    /// <summary>
    /// This class has methods to replace spaces in input string with %20
    /// </summary>
    public class ReplaceSpace
    {
        public static string ReplaceSp(string str)
        {
            char[] charstr = str.ToCharArray();
            char[] newstr = new char[charstr.Length];

            int count = 0;
            for (int i = 0; i < charstr.Length; i++)
            {
                if (charstr[i] == ' ')
                {
                    try
                    {
                        newstr[count] = '%';
                        newstr[++count] = '2';
                        newstr[++count] = '0';
                    }
                    catch
                    {

                    }
                }
                else
                {
                    newstr[count] = charstr[i];
                }
                if (count == charstr.Length - 1)
                {
                    break;
                }
                count++;
            }
            string newstring = new String(newstr);
            return newstring;
        }
    }

    /// <summary>
    /// This class tests the method in ReplaceSpace class
    /// </summary>
    internal class ReplaceSpaceTest
    {
        /// <summary>
        /// Program execution starts here
        /// </summary>
        static void Main()
        {
            string s = "Mr John Smith    ";
            string returnstring = ReplaceSpace.ReplaceSp(s);
            Console.WriteLine("New string: {0}", returnstring);
            Console.ReadLine();
        }
    }
}
