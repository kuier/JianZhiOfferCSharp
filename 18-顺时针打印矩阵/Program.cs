using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _18_顺时针打印矩阵
{
    class Program
    {
        class Solution
        {
            public List<int> printMatrix(int[][] matrix)
            {
                List<int> list = new List<int>();
                int rows = matrix.Length;
                int columns = matrix[0].Length;
                // write code here
                if (rows <=0 || columns <=0)
                {
                    return list;
                }
                int start = 0;
                while (columns > start *2 && rows > start *2)
                {
                    int endX = columns - 1 - start;
                    int endY = rows - 1 - start;
                    //从左到右打印一行
                    for (int i = start; i <= endX; i++)
                    {
                        list.Add(matrix[start][i]);
                    }
                    //从上到下打印一行
                    if (start < endY)
                    {
                        for (int i = start+1; i <= endY; i++)
                        {
                            list.Add(matrix[i][endX]);
                        }
                    }
                    //从右到左打印一行
                    if (start<endX && start <endY)
                    {
                        for (int i = endX-1; i >= start; i--)
                        {
                            list.Add(matrix[endY][i]);
                        }
                    }
                    //从下往上打印一行
                    if (start < endX && start < endY -1)
                    {
                        for (int i = endY-1; i>=start +1; i--)
                        {
                            list.Add(matrix[i][start]);
                        }
                    }
                    start ++;
                }
                return list;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
