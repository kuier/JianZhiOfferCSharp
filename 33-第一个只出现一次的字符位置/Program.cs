using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 在一个字符串(1<=字符串长度<=10000，全部由字母组成)中找到第一个只出现一次的字符的位置。若为空串，返回-1。位置索引从0开始
 */
namespace _33_第一个只出现一次的字符位置
{
    class Program
    {
        class Solution
        {
            public int FirstNotRepeatingChar(string str)
            {
                // write code here
                if (str == null || str.Length <=0)
                {
                    return -1;
                }
                Dictionary<char, int> dic = new Dictionary<char, int>();
                char[] charArray = str.ToCharArray();
                foreach (char c in charArray)
                {
                    if (dic.ContainsKey(c))
                    {
                        dic[c]++;
                    }
                    else
                    {
                        dic.Add(c,1);
                    }
                    
                }
                foreach (KeyValuePair<char, int> i in dic)
                {
                    if (i.Value ==1)
                    {
                        for (int j = 0; j < charArray.Length; j++)
                        {
                            if (i.Key == charArray[j])
                            {
                                return j;
                            }
                        }
                    }
                }
                return -1;
            }
        }
        static void Main(string[] args)
        {
            string str = "we are familyw";
            Solution s = new Solution();
            Console.WriteLine(s.FirstNotRepeatingChar(str));
            Console.ReadKey();
        }
    }
}
