using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *一个整型数组里除了两个数字之外，其他的数字都出现了两次。请写程序找出这两个只出现一次的数字 
 */
namespace _39_数组中只出现一次的数字
{
    class Program
    {
        //num1,num2分别为长度为1的数组。传出参数
        //将num1[0],num2[0]设置为返回结果
        class Solution
        {
            public void FindNumsAppearOnce(int[] array, int[] num1, int[] num2)
            {
                // write code here
                if (array == null || array.Length <2)
                {
                    return;
                }
                int resultExclusiveOr = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    resultExclusiveOr ^= array[i];
                }
                int indexof1 = 
            }

            public int FindFirstBitIs1(int num)
            {
                int indexBit = 0;
                while ((num &1) ==0)
                {
                    num = num >> 1;
                    ++indexBit;
                }
                return indexBit;
            }

            public bool IsBit1(int num, int indexBit)
            {
                num = num >> indexBit;
                return (num & 1);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
