using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 求出1~13的整数中1出现的次数,并算出100~1300的整数中1出现的次数？为此他特别数了一下1~13中包含1的数字有1、10、11、12、13因此共出现6次,但是对于后面问题他就没辙了。ACMer希望你们帮帮他,并把问题更加普遍化,可以很快的求出任意非负整数区间中1出现的次数。
 */
namespace _30_从1到n整数中1出现的次数
{
    /// <summary>
    /// 剑指offer第二种解法没有看懂。
    /// 第一种解法：对数字除10之后取余数，判断个位数字是不是1。如果大于10再次除10取余。
    /// LeetCode的解法：
    /// https://leetcode.com/discuss/44281/4-lines-o-log-n-c-java-python
    /// </summary>
    class Solution
    {
        public int NumberOf1Between1AndN_Solution(int n)
        {
            // write code here
            int ones = 0;
            for (int i = 1; i <= n; i*=10)
            {
                ones += (n / i + 8) / 10 * i + (n/i%10 ==1?(n % i + 1):0) ;
            }
            return ones;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
