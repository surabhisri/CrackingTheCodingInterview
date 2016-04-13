/* 	Program: Given an image represented by an NxN matrix, where each pixel in the image is
*	4 bytes, write a method to rotate the image by 90 degrees. Can you do this in place?
*
*	Author: Surabhi Srivastava
*
*	Date: 13-Apr-2016
*/

using System;

namespace CrackingTheCodingInterview
{
	public class RotateImage
	{
		public int[,] RotateImageFunc(int[,] matrix, n)
		{
			for(int layer = 0; layer < n/2; layer++)
			{
				int first = layer;
				int last = n-1-layer;
				for(int i = 0; i < last; i++)
				{
					int offset = i-first;
					int top = matrix[first][i];
					matrix[first][i] = matrix[last - offset][fist];
					matrix[last-offset][first] = matrix[last][last-offset];
					matrix[last][last-offset] = matrix[i][last];
					matrix[i][last] = top;
				}
			}
			return matrix;
		}
	}
	
	internal class RotateImageTest
	{
		public static void main()
		{
			 Console.WriteLine("Enter the number of rows");
            int m = Convert.ToInt32(Console.ReadLine());
            int i, j;
            int[,] matrix = new int[m,m];
            /* Loop through rows of matrix */
            for (i = 0; i < m; i++)
            {
                /* Loop through columns */
                for (j = 0; j < m; j++)
                {
                    Console.Write("[{0},{1}]: ", i, j);
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("You Entered:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", matrix[i,j]);
                }
                Console.Write(Environment.NewLine);
            }
            int[,] newmatrix = new int[m, n];
            newmatrix = RotateImage.RotateImageFunc(matrix, m);
            Console.WriteLine("New Matrix:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", newmatrix[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
            Console.ReadLine();
		}
	}
}

