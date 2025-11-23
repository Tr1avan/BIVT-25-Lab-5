using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Green
    {
        public int[] Task1(int[,] matrix)
        {
            int[] answer = null;

            // code here
            
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            answer = new int[rows]; 
            for (int i = 0; i < rows; i++)
            {
                int min = matrix[i, 0];
                int minIndex = 0;
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minIndex = j;
                    }
                }
                answer[i] = minIndex;
            }
            
            // end

            return answer;
        }
        public void Task2(int[,] matrix)
        {

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for ( int i = 0; i < rows; i++)
            {
                int max = matrix[i, 0];
                int maxIndex = 0;
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i,j] > max)
                    {
                        max = matrix[i, j];
                        maxIndex = j;
                    }
                }
                for (int j = 0; j < maxIndex; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = (int)Math.Floor((double)matrix[i, j] / max);
                    }
                }
            }
            // end

        }
        public void Task3(int[,] matrix, int k)
        {

            // code here
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            if (n != m || k < 0 || k >= m) return;

            int max = matrix[0, 0];
            int maxind = 0;

            for (int i = 0; i < n; i++)
            {
                if (matrix[i, i] > max)
                {
                    max = matrix[i, i];
                    maxind = i;
                }
            }

            if (maxind == k) return;

            for (int row = 0; row < n; row++)
            {
                (matrix[row, k], matrix[row, maxind]) = (matrix[row, maxind], matrix[row, k]);
            }

            // end

        }
        public void Task4(int[,] matrix)
        {

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int max = int.MinValue;
            int maxind = -1;

            if (rows != cols) return;

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, i] > max)
                {
                    max = matrix[i, i];
                    maxind = i;
                }

            }

            for (int i = 0; i < rows; i++)
            {
                (matrix[i, maxind], matrix[maxind, i]) = (matrix[maxind, i], matrix[i, maxind]);
            }

            // end

        }
        public int[,] Task5(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            int maxSum = 0;
            int maxInd = -1;
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                    if (matrix[i, j] > 0)
                        sum += matrix[i, j];

                if (sum > maxSum || maxInd == -1)
                {
                    maxSum = sum;
                    maxInd = i;
                }
            }

            if (maxInd != -1)
            {
                answer = new int[n - 1, m];
                int rowid = 0;
                for (int i = 0; i < n; i++)
                {
                    if (i == maxInd) continue;
                    for (int j = 0; j < m; j++)
                    {
                        answer[rowid, j] = matrix[i, j];

                    }
                    rowid++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[,] matrix)
        {

            // code here

            // end

        }
        public int[,] Task7(int[,] matrix, int[] array)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task8(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task9(int[,] matrix)
        {

            // code here

            // end

        }
        public (int[] A, int[] B) Task10(int[,] matrix)
        {
            int[] A = null, B = null;

            // code here

            // end

            return (A, B);
        }
        public void Task11(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task12(int[][] array)
        {

            // code here

            // end

        }
    }
}
