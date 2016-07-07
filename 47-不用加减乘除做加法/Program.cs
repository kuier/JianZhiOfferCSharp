using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 写一个函数，求两个整数之和，要求在函数体内不得使用+、-、*、/四则运算符号。
 */
namespace _47_不用加减乘除做加法
{
    class Program
    {
        class Solution
        {
            public int Add(int num1, int num2)
            {
                // write code here
                int sum, carry;
                do
                {
                    sum = num1 ^ num2;
                    carry = (num1 & num2) << 1;
                    num1 = sum;
                    num2 = carry;
                } while (num2!=0);
                return num1;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
