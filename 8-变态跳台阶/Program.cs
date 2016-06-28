using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 题目描述

一只青蛙一次可以跳上1级台阶，也可以跳上2级……它也可以跳上n级。求该青蛙跳上一个n级的台阶总共有多少种跳法。
 * 
 * 解：可以用数学归纳法证明f(n) = 2^(n-1);
 * 或者思考：每个台阶都有跳和不跳两种情况（除了最后一个台阶），最后一个台阶必须跳，所以是2^(n-1)
 * 还可以：2^(n-1)，就是将1左移（n-1）位，移位的效率更高
 */

namespace _8_变态跳台阶
{
    class Program
    {
        class Solution
        {
            public int jumpFloorII(int number)
            {
                // write code here
                //return (int) Math.Pow(2, number - 1);
                return 1 << (number - 1);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
