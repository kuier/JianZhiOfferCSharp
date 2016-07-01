using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 输入n个整数，找出其中最小的K个数。例如输入4,5,1,6,2,7,3,8这8个数字，则最小的4个数字是1,2,3,4,。
 */
namespace _28_最小的k个数
{
    class Program
    {
        /// <summary>
        /// 采用冒泡排序的思想，只不过最外层循环k次就可以了。不用全部排序。
        /// </summary>
        class Solution
        {
            public List<int> GetLeastNumbers_Solution(int[] input, int k)
            {
                // write code here
                List<int> list = new List<int>();
                if (k>input.Length)
                {
                    return list;
                }
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < input.Length-i-1; j++)
                    {
                        if (input[j]<input[j+1])
                        {
                            int temp = input[j];
                            input[j] = input[j + 1];
                            input[j + 1] = temp;
                        }
                    }
                    list.Add(input[input.Length-i-1]);
                }
                return list;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
