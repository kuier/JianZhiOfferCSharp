using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_用两个栈实现队列
{
    class Solution
    {
        private Stack<int> stack1 = new Stack<int>();
        private Stack<int> stack2 = new Stack<int>();
        public void push(int node)
        {
            stack1.Push(node);
        }
        public int pop()
        {
            if (stack2.Count ==0)
            {
                int m = stack1.Count;
                for (int i = 0; i < m; i++)
                {
                    stack2.Push(stack1.Pop());
                }
                return stack2.Pop();
            }
            else
            {
                return stack2.Pop();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.push(1);
            s.push(2);
            s.push(3);
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            s.push(4);
            Console.WriteLine(s.pop());
            s.push(5);
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Console.Read();
        }
    }
}
