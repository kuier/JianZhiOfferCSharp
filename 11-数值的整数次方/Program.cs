using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 给定一个double类型的浮点数base和int类型的整数exponent。求base的exponent次方。
 * 主要考察的就是错误的处理方式，如果输入不合法，底数为0等等情况都需要考虑到
 */

namespace _11_数值的整数次方
{
    class Program
    {
        class Solution
        {
            private bool invalidInput = false;
            public double Power(double thebase, int exponent)
            {
                // write code here
                if (thebase.Equals(0) && exponent <0 )
                {
                    invalidInput = true;
                    return 0.0;
                }
                int absExponent = exponent;
                if (exponent <0)
                {
                    absExponent = -exponent;
                }
                double result = PowerWithUnsignedExponent(thebase, absExponent);
                if (exponent <0)
                {
                    result = 1.0/result;
                }
                return result;
            }

            double PowerWithUnsignedExponent1(double thebase, int exponent)
            {
                double result = 1.0;
                for (int i = 0; i < exponent; i++)
                {
                    result *= thebase;
                }
                return result;
            }

            private double PowerWithUnsignedExponent(double thebase, int exponent)
            {
                if (exponent ==0)
                {
                    return 1;
                }
                if (exponent == 1)
                {
                    return thebase;
                }
                double result = PowerWithUnsignedExponent(thebase, exponent >> 1);
                result *= result;
                if ((exponent&0x1) ==1)
                {
                    result *= thebase;
                }
                return result;
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("base:");
                string thebase = Console.ReadLine();
                Console.Write("exponent:");
                string exponent = Console.ReadLine();
                if (thebase == "q" || exponent == "q")
                {
                    Console.WriteLine("结束");
                    break;
                }
                int thebaseint = Convert.ToInt32(thebase);
                int exponentint = Convert.ToInt32(exponent);
                Solution s = new Solution();
                Console.WriteLine("结果是："+s.Power(thebaseint,exponentint));
            }
        }
    }
}
