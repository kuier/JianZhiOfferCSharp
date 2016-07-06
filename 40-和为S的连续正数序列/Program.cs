using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 小明很喜欢数学,有一天他在做数学作业时,要求计算出9~16的和,他马上就写出了正确答案是100。但是他并不满足于此,他在想究竟有多少种连续的正数序列的和为100(至少包括两个数)。没多久,他就得到另一组连续正数和为100的序列:18,19,20,21,22。现在把问题交给你,你能不能也很快的找出所有和为S的连续正数序列? Good Luck! 
 */
namespace _40_和为S的连续正数序列
{
    using System.Collections.Generic;
    class Solution
    {
        List<List<int>> resultList = new List<List<int>>();
        public List<List<int>> FindContinuousSequence(int sum)
        {
            // write code here
            if (sum <3)
            {
                return resultList;
            }
            int small = 1;
            int big = 2;
            int middle = (1 + sum)/2;
            int cursum = small + big;
            while (small <middle)
            {
                if (cursum == sum)
                {
                    AddToList(small,big);
                }
                while (cursum >sum && small < middle)
                {
                    cursum -= small;
                    small ++;
                    if (cursum == sum)
                    {
                        AddToList(small,big);
                    }
                }
                big++;
                cursum += big;
            }
            return resultList;
        }

        private void AddToList(int small, int big)
        {
            List<int> tempList = new List<int>();
            for (int i = small; i <= big; i++)
            {
                tempList.Add(i);
            }
            resultList.Add(tempList);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
