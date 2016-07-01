using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 数组中有一个数字出现的次数超过数组长度的一半，请找出这个数字。例如输入一个长度为9的数组{1,2,3,2,2,2,5,4,2}。由于数字2在数组中出现了5次，超过数组长度的一半，因此输出2。如果不存在则输出0。
 * 解法：
 * 数组中有一个数字出现的次数超过数组长度的一半，也就是说他出现的次数比其他所有数字出现的次数之和还要多，因此我们在考虑遍历数组的时候保存两个值：一个是数组中的一个数字，一个事次数。当我们遍历到下一个数字的时候，如果和以前的数字相同就加1，如果不同次数减1，如果次数为0，就保存这个数字，并置为1.要找的数字肯定是最后一次把次数置为1时对应的数字。
 */
namespace _27_数组中出现次数超过一半的数字
{
    class Program
    {
        class Solution
        {
            public int MoreThanHalfNum_Solution(int[] numbers)
            {
                // write code here
                if (numbers == null || numbers.Length ==0)
                {
                    return 0;
                }
                int result = numbers[0];
                int times = 1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (times ==0)
                    {
                        result = numbers[i];
                        times = 1;
                    }
                    else if (numbers[i] == result)
                    {
                        times ++;
                    }
                    else
                    {
                        times--;
                    }
                }
                times = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (result == numbers[i])
                    {
                        times ++;
                    }
                }
                if (numbers.Length/2 <times)
                {
                    return result;
                }
                return 0;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
