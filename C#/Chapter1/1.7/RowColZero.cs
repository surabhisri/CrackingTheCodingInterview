/* Program: For 0 in any row or column of 2D array convert the entire row and column elements to 0
*
*   Author: Surabhi Srivastava
*
*   Date: 11-Apr-2016
*/

using System;
using System.Collections;

namespace CrackingTheCodingInterview
{
    /// <summary>
    /// Class contains the method to convert all the elements of 0 containing row and column of the metrix to 0
    /// </summary>
    public class RowColZero
    {
        /// <summary>
        /// Function: If an element in an MxN matrix is 0, its entire row and column are set to 0.
        /// </summary>
        /// <param name="matrix">2D Array</param>
        /// <param name="m">No of rows</param>
        /// <param name="n">No of columns</param>
        /// <returns>New Matrix</returns>
        public static int[,] RowColZeroFunc(int[,] matrix, int m, int n)
        {
            int limit = m > n ? m : n;
            Hashtable Ht_row = new Hashtable();
            Hashtable Ht_col = new Hashtable();
            int count = 1;
            /* Loop through rows of matrix */
            for (int i = 0; i < m; i++)
            {
                /* Loop through columns of matrix */
                for (int j = 0; j < n; j++)
                {
                    /* If 0 is found at any point and it is not converted by our conversion */
                    if (matrix[i,j] == 0 && !Ht_col.ContainsValue(j) && !Ht_row.ContainsValue(i))
                    {
                        for (int k = 0; k < limit; k++)
                        {
                            if (k < m)
                            {
                                matrix[k,j] = 0;
                            }
                            if (k < n)
                            {
                                matrix[i,k] = 0;
                            }                                                                 
                        }
                        Ht_col.Add(count, j);
                        Ht_row.Add(count, i);
                        count++;
                    }
                }
            }
            return matrix;
        }
        /// <summary>
        /// Function: If an element in an MxN matrix is 0, its entire row and column are set to 0.
        /// </summary>
        /// <param name="matrix">2D Array</param>
        /// <param name="m">No of rows</param>
        /// <param name="n">No of columns</param>
        /// <returns>New Matrix</returns>
        public static int[,] RowColZeroFunc_Optimized(int[,] matrix, int m, int n)
        {
            int limit = m > n ? m : n;
            Hashtable Ht_row = new Hashtable();
            Hashtable Ht_col = new Hashtable();
            int count = 1;
            /* Loop through rows of matrix */
            for (int i = 0; i < m; i++)
            {
                /* Loop through columns of matrix */
                for (int j = 0; j < n; j++)
                {
                    /* If 0 is found put its index in hash table */
                    if (matrix[i, j] == 0)
                    {    
                        if(!Ht_col.ContainsValue(i))
                        {
                            Ht_col.Add(count + 1, i);
                        }
                        if (!Ht_col.ContainsValue(j))
                        {
                            Ht_col.Add(count+1, j);
                        }                                      
                        count++;
                    }
                }
                /* Full loop */
                for (int k = 0; k < limit; k++)
                {   
                    /* Loop through has table and convert all rows and zero corresponding to the values of hash table values */               
                    foreach(DictionaryEntry ent in Ht_col)
                    {
                        if (k < m)
                        {
                            matrix[k, Convert.ToInt32(ent.Value)] = 0;
                        }
                        if (k < n && (Convert.ToInt32(ent.Value)) < m)
                        {
                            matrix[Convert.ToInt32(ent.Value), k] = 0;
                        }
                    }               
                }
            }
            return matrix;
        }
    }

    /// <summary>
    /// This class tests the class RowColZero
    /// </summary>
    internal class RowColZeroTest
    {
        /// <summary>
        /// Program execution starts here
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter the number of rows");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            int n = Convert.ToInt32(Console.ReadLine());
            int i, j;
            int[,] matrix = new int[m,n];
            /* Loop through rows of matrix */
            for (i = 0; i < m; i++)
            {
                /* Loop through columns */
                for (j = 0; j < n; j++)
                {
                    Console.Write("[{0},{1}]: ", i, j);
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("You Entered:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", matrix[i,j]);
                }
                Console.Write(Environment.NewLine);
            }
            int[,] newmatrix = new int[m, n];
            newmatrix = RowColZero.RowColZeroFunc_Optimized(matrix, m, n);
            Console.WriteLine("New Matrix:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", newmatrix[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
            Console.ReadLine();
        }
    }
}