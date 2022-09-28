using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JC.CSharpAlgorithm
{
    //题目介绍：https://www.cnblogs.com/edisonchou/p/4737944.html
    public static class MatrixSearch
    {
        public static bool Find(int[][] matrix, int findNumber)
        {
            ArgumentNullException.ThrowIfNull(matrix);
            ArgumentNullException.ThrowIfNull(findNumber);
            bool isFound = false;

            int row = 0;
            int col = 0;

            while (row < matrix.Length)
            {
                col = matrix[row].Length - 1;
                for (int i = col; i > 0; i--)
                {
                    if (matrix[row][i] == findNumber)
                    {
                        isFound = true;
                        break;
                    }
                    if (matrix[row][i] <= findNumber)
                    {
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
                row++;
            }

            return isFound;
        }
    }
}