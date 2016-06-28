using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 题目描述：我们可以用2*1的小矩形横着或者竖着去覆盖更大的矩形。请问用n个2*1的小矩形无重叠地覆盖一个2*n的大矩形，总共有多少种方法？
 * 我们先把2*8的覆盖方法记为f(8).用第一个1*2小矩形去覆盖大矩形的最左边时有两种选择，竖着放或横着放。竖着放的时候剩下的就是f(7)，横着放的时候，只能是两个小矩形都横着放，剩下的是f(6)，所以就是f(8) = f(7) + f(6)，为斐波那契数列
 */

namespace _9_矩形覆盖
{
    class Program
    {
        class Solution
        {
            public int rectCover(int number)
            {
                // write code here
                if (number == 0 || number == 1)
                {
                    return number;
                }
                if (number == 2)
                {
                    return 2;
                }
                int fibNMinusOne = 1;
                int fibNMinusTwo = 2;
                int fibN = 0;
                for (int i = 2; i < number; i++)
                {
                    fibN = fibNMinusOne + fibNMinusTwo;
                    fibNMinusOne = fibNMinusTwo;
                    fibNMinusTwo = fibN;
                }
                return fibN;
            }
        }
        static void Main(string[] args)
        {
//            Solution s = new Solution();
//            Console.WriteLine(s.rectCover(3));
//            Console.Read();
//            string line;
//            while ((line = System.Console.ReadLine()) != null)
//            {//注意while处理多个case
//                string[] tokens = line.Split();
//                System.Console.WriteLine(int.Parse(tokens[0]) + int.Parse(tokens[1]));
//            }
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "q")
                {
                    Console.WriteLine("结束");
                    return;
                }
                else
                {
                    int number = Convert.ToInt32(s);
                    Solution solution = new Solution();
                    Console.WriteLine("结果是："+solution.rectCover(number));
                } 
            }
        }
    }
}
