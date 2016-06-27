using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_斐波那契数列
{
    /// <summary>
    /// 这里还有一个跳台阶问题，本质上也是斐波那契数列问题。
    /// </summary>
    class Program
    {
        class Solution
        {
            public int Fibonacci(int n)
            {
                if (n == 0)
                {
                    return 0;
                }
                // write code here
                if (n == 1)
                {
                    return 1;
                }
                int fibNMinusOne = 0;
                int fibNMinusTwo = 1;
                int fibN = 0;
                for (int i = 1; i < n; i++)
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
            Solution s = new Solution();
            Console.WriteLine(s.Fibonacci(3));
            Console.Read();
        }
    }
}
