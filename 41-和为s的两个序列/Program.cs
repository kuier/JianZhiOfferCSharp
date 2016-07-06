using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 输入一个递增排序的数组和一个数字S，在数组中查找两个数，使得他们的和正好是S，如果有多对数字的和等于S，输出两个数的乘积最小
 */
namespace _41_和为s的两个序列
{
    class Solution
    {
        public List<int> FindNumbersWithSum(int[] array, int sum)
        {
            // write code here
            List<int> resultList = new List<int>();
            if (array.Length <=0)
            {
                return resultList;
            }
            int ahead = 0;
            int behind = array.Length - 1;
            while (ahead < behind)
            {
                int curSum = array[ahead] + array[behind];
                if (curSum == sum)
                {
                    resultList.Add(array[ahead]);
                    resultList.Add(array[behind]);
                    return resultList;
                }
                else if(curSum < sum)
                {
                    ahead++;
                }
                else
                {
                    behind--;
                }
            }
            return resultList;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
