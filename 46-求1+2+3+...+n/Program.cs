using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 求1+2+3+...+n，要求不能使用乘除法、for、while、if、else、switch、case等关键字及条件判断语句（A?B:C）。
 */
namespace _46_求1_2_3_._._._n
{

    class Program
    {
        class Solution
        {
            //诀窍就是使用&&来截至
            public int Sum_Solution(int n)
            {
                // write code here
                int ans = n;
                bool judge = (n != 0) && ((ans += Sum_Solution(n - 1)) != 0);
                return ans;

            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.Sum_Solution(10));
            Console.ReadLine();
        }
    }
}
