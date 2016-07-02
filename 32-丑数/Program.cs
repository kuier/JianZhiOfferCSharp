using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*
 * 把只包含因子2、3和5的数称作丑数（Ugly Number）。例如6、8都是丑数，但14不是，因为它包含因子7。 习惯上我们把1当做是第一个丑数。求按从小到大的顺序的第N个丑数。
 */
namespace _32_丑数
{
    class Program
    {
        class Solution
        {
            public int GetUglyNumber_Solution(int index)
            {
                // write code here
                if (index <=0)
                {
                    return 0;
                }
                int[] uglyNumbers = new int[index];
                uglyNumbers[0] = 1;
                int nextUglyIndex = 1;

                int multiply2 = 0;//指向丑数中第一个*2比最大丑数大的位置。
                int multiply3 = 0;
                int multiply5 = 0;
                while (nextUglyIndex <index)
                {
                    int min = Min(2 * uglyNumbers[multiply2], 3 * uglyNumbers[multiply3], 5 * uglyNumbers[multiply5]);
                    uglyNumbers[nextUglyIndex] = min;
                    while (2 * uglyNumbers[multiply2] <= uglyNumbers[nextUglyIndex])
                    {
                        multiply2 ++;
                    }
                    while (3 * uglyNumbers[multiply3] <= uglyNumbers[nextUglyIndex])
                    {
                        multiply3 ++;
                    }
                    while (5 * uglyNumbers[multiply5] <= uglyNumbers[nextUglyIndex])
                    {
                        multiply5++;
                    }
                    nextUglyIndex ++;
                }
                return uglyNumbers[nextUglyIndex - 1];
            }

            public int Min(int number1, int number2, int number3)
            {
                int min = (number1 < number2) ? number1 : number2;
                min = (min < number3) ? min : number3;
                return min;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.GetUglyNumber_Solution(11));
            Console.Read();
        }
    }
}
