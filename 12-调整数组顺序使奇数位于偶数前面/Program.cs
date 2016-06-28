using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 输入一个整数数组，实现一个函数来调整该数组中数字的顺序，使得所有的奇数位于数组的前半部分，所有的偶数位于位于数组的后半部分，并保证奇数和奇数，偶数和偶数之间的相对位置不变。
 */

namespace _12_调整数组顺序使奇数位于偶数前面
{
    class Program
    {
        class Solution
        {
            public int[] reOrderArray(int[] array)
            {
                List<int> jishuList = new List<int>();
                List<int> oushuList = new List<int>();
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i]%2 == 1)
                    {
                        jishuList.Add(array[i]);
                        continue;
                    }
                    oushuList.Add(array[i]);
                }
                int[] newArray = new int[array.Length];
                for (int i = 0; i < jishuList.Count; i++)
                {
                    newArray[i] = jishuList[i];
                }
                for (int i = 0; i < oushuList.Count; i++)
                {
                    newArray[jishuList.Count + i] = oushuList[i];
                }
                return newArray;
            }
        }
        static void Main(string[] args)
        {
            int[] array = new[] {1, 2, 3, 4, 5, 6};
            Solution s = new Solution();
            int[] newArray = s.reOrderArray(array);
        }
    }
}
