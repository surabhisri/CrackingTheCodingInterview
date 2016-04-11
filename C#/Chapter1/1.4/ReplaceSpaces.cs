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
		public static string Replaceinplace(string str)
		{
			char[] charstr = str.ToCharArray();
			int count_i = 0;
			for(int i = 0; i < charstr.Length; i++)
			{
				if(charstr[i] == ' ')
				{
					count_i++;
				}
			}
			int buffer_count = 2*count_i/3;
			if(buffer_count % 3 != 0)
			{
				return "False String";
			}
			else
			{
				int counter = charstr[j].Length - 1;
				for(int j = charstr[j].Length - buffer_count; j >= 0; j--)
				{
					if(charstr[j] == ' ')
					{
						charstr[counter] = '0';
						charstr[--counter] = '2';
						charstr[--counter] = '%';
					}
					else
					{
						charstr[counter] = charstr[j];
						counter--;
					}
				}
			}
			string newstring = new String(charstr);
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
