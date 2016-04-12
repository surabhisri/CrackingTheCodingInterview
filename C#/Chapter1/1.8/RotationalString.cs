/*	Program: Program to check if one word is asubstring of another. Given two strings, we have checked if s2 is
*	a rotation of s1 using only one call to isSubstring (e.g.,"waterbottle"is a rotation of "erbottlewat").
*
*	Author: Surabhi Srivastava
*
*	Date: 12-Apr-2016
*/

using System;

namespace CrackingThecodingInterview
{
    /// <summary>
    /// Class contains the method to check whether the second string is rotational substring of first or not
    /// </summary>
    public class RotationalString
    {
        /// <summary>
        /// Function concatinates both the strings and assigns the result to first string and the we will check if the second string is substring of first or not
        /// </summary>
        /// <param name="s1">First String</param>
        /// <param name="s2">Second String</param>
        /// <returns>True/False</returns>
        public static bool IsSubstring(string s1, string s2)
        {
            s1 = s1 + s2;
            return (s1.Contains(s2));
        }
    }

    /// <summary>
    /// Class to test RotationalString Class
    /// </summary>
    internal class RotationalStringTest
    {
        /// <summary>
        /// Program execution starts here
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter String 1:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter String 2:");
            string s2 = Console.ReadLine();
            /* If function returns true and length of both string are same */
            if (RotationalString.IsSubstring(s1, s2) && s1.Length == s2.Length)
            {
                Console.WriteLine("It is a rotational substring");
            }
            else
            {
                Console.WriteLine("Not a rotational Substring");
            }
            Console.ReadLine();
        }
    }
}