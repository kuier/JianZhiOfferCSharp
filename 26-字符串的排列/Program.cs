using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 输入一个字符串,按字典序打印出该字符串中字符的所有排列。例如输入字符串abc,则打印出由字符a,b,c所能排列出来的所有字符串abc,acb,bac,bca,cab和cba。 结果请按字母顺序输出。 
 * 解法：
 * 首先求所有可能出现在第一个位置的字符，即把第一个字符和后面所有的字符交换。
 * 第二步是固定第一个字符，求所有后面的字符的排列。典型的递归思想
 */
namespace _26_字符串的排列
{
    class Program
    {
        class Solution
        {
            public List<string> Permutation(string str)
            {
                // write code here
                List<string> list = new List<string>();
                if (str == null || str == "")
                {
                    return list;
                }
                func(list, str.ToCharArray(), 0);
                list.Sort();
                return list;
            }

            private void func(List<string> list, char[] str, int begin)
            {
                if (begin == str.Length)
                {
                    list.Add(new string(str));
                }
                else
                {
                    for (int i = begin; i < str.Length; i++)
                    {
                        //跳过那些重复的
                        if (i!=begin && str[i] == str[begin])
                        {
                            continue;
                        }
                        char temp = str[begin];
                        str[begin] = str[i];
                        str[i] = temp;

                        func(list, str, begin + 1);

                        temp = str[begin];
                        str[begin] = str[i];
                        str[i] = temp;

                    }
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
