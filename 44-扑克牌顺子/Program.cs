using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * LL今天心情特别好,因为他去买了一副扑克牌,发现里面居然有2个大王,2个小王(一副牌原本是54张^_^)...他随机从中抽出了5张牌,想测测自己的手气,看看能不能抽到顺子,如果抽到的话,他决定去买体育彩票,嘿嘿！！“红心A,黑桃3,小王,大王,方片5”,“Oh My God!”不是顺子.....LL不高兴了,他想了想,决定大\小 王可以看成任何数字,并且A看作1,J为11,Q为12,K为13。上面的5张牌就可以变成“1,2,3,4,5”(大小王分别看作2和4),“So Lucky!”。LL决定去买体育彩票啦。 现在,要求你使用这幅牌模拟上面的过程,然后告诉我们LL的运气如何。为了方便起见,你可以认为大小王是0。
 */
namespace _44_扑克牌顺子
{
    class Program
    {
        /// <summary>
        /// 必须满足两个条件：
        /// 1：除0之外没有重复的数字
        /// 2：最大值减去最小值(不包括0)小于等于5
        /// </summary>
        class Solution
        {
            public bool IsContinuous(int[] numbers)
            {
                // write code here
                if (numbers.Length <=0)
                {
                    return false;
                }
                SelectSort(numbers);
                int zeroCount = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] ==0)
                    {
                        zeroCount++;
                    }
                }
                //这是检测最大值减去最小值小于等于5
                if (numbers[numbers.Length-1] - numbers[zeroCount] > 4)
                {
                    return false;
                }
                //检测有没有重复的数字
                for (int i = zeroCount; i < numbers.Length-1; i++)
                {
                    if (numbers[zeroCount] == numbers[zeroCount+1])
                    {
                        return false;
                    }
                }
                return true;
            }

            private void SelectSort(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    int min = i;
                    for (int j = i+1; j < numbers.Length; j++)
                    {
                        if (less(numbers[j],numbers[min]))
                        {
                            min = j;
                        }
                    }
                    exch(numbers,i,min);
                }
            }

            private bool less(int i, int j)
            {
                return i < j ? true : false;
            }
            private void exch(int[] numbers, int i, int j)
            {
                int temp = numbers[j];
                numbers[j] = numbers[i];
                numbers[i] = temp;
            }
        }
        static void Main(string[] args)
        {
            int[] array = new[] {1, 3, 2, 6, 4};
            Solution s = new Solution();
            Console.WriteLine(s.IsContinuous(array));
            Console.ReadLine();
        }
    }
}
