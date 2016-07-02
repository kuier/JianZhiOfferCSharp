using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 输入一个正整数数组，把数组里所有数字拼接起来排成一个数，打印能拼接出的所有数字中最小的一个。例如输入数组{3，32，321}，则打印出这三个数字能排成的最小数字为321323。
 * 重点在于写一个比较器，实现ICompare接口
 */
namespace _31_把数组排成最小的数
{
    class Program
    {
        class Solution
        {
            public string PrintMinNumber(int[] numbers)
            {
                // write code here
                if (numbers == null || numbers.Length ==0)
                {
                    return "";
                }
                string[] str = new string[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    str[i] = numbers[i].ToString();
                }
                strCompare strCompare = new strCompare();
                Array.Sort(str,strCompare);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < str.Length; i++)
                {
                    sb.Append(str[i]);
                }
                return sb.ToString();
            }

            public class strCompare:IComparer<String>
            {
                public int Compare(string x, string y)
                {
                    string str1 = x + y;
                    string str2 = y + x;
                    return str1.CompareTo(str2);
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
