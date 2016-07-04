using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 在数组中的两个数字，如果前面一个数字大于后面的数字，则这两个数字组成一个逆序对。输入一个数组，求出这个数组中的逆序对的总数。
 */
namespace _34_数组中的逆序对
{
    class Program
    {
        class Solution
        {
            public int InversePairs(int[] data)
            {
                // write code here
                int count = 0;
                for (int i = 0; i < data.Length-1; i++)
                {
                    for (int j = i+1; j < data.Length; j++)
                    {
                        if (data[i]>data[j])
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
