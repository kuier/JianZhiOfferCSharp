using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 统计一个数字在排序数组中出现的次数。
 */
namespace _36_数字在排序数组中出现的次数
{
    class Program
    {
        class Solution
        {
            /// <summary>
            /// 暴力法，找到第一个k,记下坐标，找最后一个k
            /// </summary>
            /// <param name="data"></param>
            /// <param name="k"></param>
            /// <returns></returns>
            public int GetNumberOfK(int[] data, int k)
            {
                // write code here
                if (data.Length <=0)
                {
                    return 0;
                }
                if (k<data[0] || k>data[data.Length-1])
                {
                    return 0;
                }
                int result = 0;
                //int first = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    //第一次找到目标数
                    #region 这段代码有问题。提示没有处理多个循环测试用例
//                    if (data[i] == k)
//                    {
//                        while (data[i] == k)
//                        {
//                            result++;
//                            i++;
//                        }
//                        break;
//                    }
                    #endregion

                    if (data[i] == k)
                    {
                        result ++;
                    }
                    
                }
                return result;
            }
        }
        static void Main(string[] args)
        {
            int[] test = new int[]{1,2,3,3,3,3,4,5};
            Solution s= new Solution();
            Console.WriteLine(s.GetNumberOfK(test,3));
        }
    }
}
