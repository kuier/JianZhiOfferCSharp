using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1_二维数组查找
{
    class Program
    {
        public static bool Find(int[][] array, int target)
        {
            // write code here
            bool found = false;
            int m = array.GetLength(0); //行数
            int n = array[0].Length;    //列数

            int row = 0;
            int column = n - 1;
            while (row<m&&column>=0)
            {
                if (array[row][column] == target)
                {
                    found = true;
                    break;
                }
                else if(array[row][column] > target)
                {
                    column--;
                }
                else
                {
                    row++;
                }
            }

            return found;
        }
        static void Main(string[] args)
        {
            int[][] jaggedArray3 = 
                                {
                                    new int[] {1,2,8,9},
                                    new int[] {2,4,9,12},
                                    new int[] {4,7,10,13},
                                    new int[]{6,8,11,15},
                                    new int[]{8,10,12,17}, 
                                };
            //int[,] array = new int[4, 3]{{1,2,8,9},};
            Console.WriteLine(Find(jaggedArray3, 10));
            Console.ReadKey();
        }
        
    }
}
