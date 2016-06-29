using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 输入两个整数序列，第一个序列表示栈的压入顺序，请判断第二个序列是否为该栈的弹出顺序。假设压入栈的所有数字均不相等。例如序列1,2,3,4,5是某栈的压入顺序，序列4，5,3,2,1是该压栈序列对应的一个弹出序列，但4,3,5,1,2就不可能是该压栈序列的弹出序列。
 * 思路：
 * 利用一个辅助栈，把pushV中的元素挨个放到辅助栈中，并判断辅助栈的栈顶元素和popV的元素是否相等，如果相等就弹出辅助栈的栈顶元素，最后判断辅助栈中是否还有其他元素，没有的话就是子栈。
 */
namespace _20_栈的压入_弹出序列
{
    class Program
    {
        class Solution
        {
            public bool IsPopOrder(int[] pushV, int[] popV)
            {
                // write code here
                if (pushV.Length == 0)
                {
                    return false;
                }
                Stack<int> stack = new Stack<int>();
                for (int i = 0,j=0; i < pushV.Length; i++)
                {
                    stack.Push(pushV[i]);
                    while (j<popV.Length && stack.Peek() == popV[j])
                    {
                        stack.Pop();
                        j++;
                    }
                }
                return stack.Count == 0;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
