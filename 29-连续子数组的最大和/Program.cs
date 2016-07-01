﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * HZ偶尔会拿些专业问题来忽悠那些非计算机专业的同学。今天测试组开完会后,他又发话了:在古老的一维模式识别中,常常需要计算连续子向量的最大和,当向量全为正数的时候,问题很好解决。但是,如果向量中包含负数,是否应该包含某个负数,并期望旁边的正数会弥补它呢？例如:{6,-3,-2,7,-15,1,2,2},连续子向量的最大和为8(从第0个开始,到第3个为止)。你会不会被他忽悠住？
 */
namespace _29_连续子数组的最大和
{
    class Program
    {
        /// <summary>
        /// 总体思路就是保存当前和和最大子数组和,这里注意的就是greatSum一开始要设置的比较小。
        /// </summary>
        class Solution
        {
            public int FindGreatestSumOfSubArray(int[] array)
            {
                // write code here
                if (array.Length == 0 || array == null)
                {
                    return 0;
                }
                int curSum = 0;
                int greatSum = -1<<10;
                for (int i = 0; i < array.Length; i++)
                {
                    if (curSum <= 0)
                    {
                        curSum = array[i];
                    }
                    else
                    {
                        curSum += array[i];
                    }
                    if (curSum > greatSum)
                    {
                        greatSum = curSum;
                    }
                }
                return greatSum;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
