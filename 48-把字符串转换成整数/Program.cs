using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_把字符串转换成整数
{
    class Program
    {
        /// <summary>
        /// ASCII 48-57为0-9。不是这里面的不是数字
        /// </summary>
        class Solution
        {
            public int StrToInt(string str)
            {
                // write code here
                if (str.Equals("") || str.Length ==0)
                {
                    return 0;
                }
                char[] charArray = str.ToCharArray();
                int fushu = 0;
                if (charArray[0] == '-')
                {
                    fushu = 1;
                }
                int sum = 0;
                for (int i = fushu; i < charArray.Length; i++)
                {
                    if (charArray[i] == '+')
                    {
                        continue;
                    }
                    if (charArray[i]<48||charArray[i]>57)
                    {
                        return 0;
                    }
                    sum = sum*10 + charArray[i] - 48;
                }
                return fushu == 0 ? sum : sum*-1;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.StrToInt("+123"));
        }
    }
}
