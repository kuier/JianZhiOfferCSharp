using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 定义栈的数据结构，请在该类型中实现一个能够得到栈最小元素的min函数。
 */
namespace _19_包含min函数的栈
{
    class Program
    {
        class Solution
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> minStack = new Stack<int>(); 
            public void push(int node)
            {
                stack.Push(node);
                if (node < min())
                {
                    minStack.Push(node);
                }
                else
                {
                    minStack.Push(min());
                }
            }
            public void pop()
            {
                stack.Pop();
                minStack.Pop();
            }
            public int top()
            {
                int val = stack.Pop();
                stack.Push(val);
                return val;
            }
            public int min()
            {
                if (minStack.Count <=0)
                {
                    return 9999;
                }
                int val = minStack.Pop();
                minStack.Push(val);
                return val;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.push(1);
            s.push(2);
            s.push(3);
            s.push(4);

            Console.WriteLine(s.min());
            s.pop();
            Console.WriteLine(s.min());
            s.pop();
            Console.WriteLine(s.min());
            Console.ReadKey();
        }
    }
}
