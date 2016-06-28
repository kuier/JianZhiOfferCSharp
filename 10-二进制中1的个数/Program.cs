using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*
 * 题目描述:输入一个整数，输出该数二进制表示中1的个数。其中负数用补码表示。
 * 
 */

namespace _10_二进制中1的个数
{
    class Program
    {
        class Solution
        {
            #region 正解
            public int NumberOf11(int n)
            {
                // write code here
                int count = 0;
                int flag = 1;
                while (flag != 0)
                {
                    if ((n & flag) != 0)
                    {
                        count++;
                    }
                    flag = flag << 1;
                }
                return count;
            } 
            #endregion

            public int NumberOf1(int n)
            {
                int count = 0;
                int flag = 1;
                while (n !=0)
                {
                    count++;
                    n = (n - 1) & n;
                }
                return count;
            }

            #region 最优解

            #endregion
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "q")
                {
                    Console.WriteLine("结束");
                    break;
                }
                int n = Convert.ToInt32(s);
                Solution solution = new Solution();
                Console.WriteLine("结果是："+solution.NumberOf1(n));
            }
        }
    }
}
