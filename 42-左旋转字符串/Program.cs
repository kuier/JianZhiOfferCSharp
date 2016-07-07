using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 汇编语言中有一种移位指令叫做循环左移（ROL），现在有个简单的任务，就是用字符串模拟这个指令的运算结果。对于一个给定的字符序列S，请你把其循环左移K位后的序列输出。例如，字符序列S=”abcXYZdef”,要求输出循环左移3位后的结果，即“XYZdefabc”。是不是很简单？OK，搞定它！
 */
namespace _42_左旋转字符串
{

    class Program
    {
        class Solution
        {
            /// <summary>
            /// 注意返回值，为null还是空字符串
            /// </summary>
            /// <param name="str"></param>
            /// <param name="n"></param>
            /// <returns></returns>
            public string LeftRotateString(string str, int n)
            {
                // write code here
                //字符串长度
                int strLength = str.Length;
                if (strLength ==0)
                {
                    return "";
                }
                //从第几个开始
                n = n%strLength;
                str += str;
                string result = str.Substring(n, strLength);
                return result;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.LeftRotateString("abcdefg",2));
        }
    }
}
