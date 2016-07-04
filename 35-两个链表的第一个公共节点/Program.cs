using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*
 * 输入两个链表，找出它们的第一个公共结点
 */
namespace _35_两个链表的第一个公共节点
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }
    /// <summary>
    /// 解法1：需要辅助的栈,错误提示你的代码仅仅处理了一个测试用例，没有循环处理多个测试用例，我也没弄懂为什么
    /// </summary>
    class Solution1
    {
        public ListNode FindFirstCommonNode(ListNode pHead1, ListNode pHead2)
        {
            // write code here
            ListNode result = null;
            if (pHead1 ==null||pHead2 == null)
            {
                return result;
            }
            Stack<ListNode> stack1 = new Stack<ListNode>();
            Stack<ListNode> stack2 = new Stack<ListNode>();
            ListNode listNode1 = pHead1;
            ListNode listNode2 = pHead2;
            while (listNode1!= null)
            {
                stack1.Push(listNode1);
                listNode1 = listNode1.next;
            }
            while (listNode2!= null)
            {
                stack2.Push(listNode2);
                listNode2 = listNode2.next;
            }
            while (stack1.Peek() == stack2.Peek())
            {
                result = stack1.Pop();
                stack2.Pop();
            }
            return result;
        }
    }
    class Solution
    {
        public ListNode FindFirstCommonNode(ListNode pHead1, ListNode pHead2)
        {
            // write code here
            ListNode listNodeLong = pHead1;
            ListNode listNodeShort = pHead2;
            ListNode result = null;
            int pHead1Length = GetListLength(pHead1);
            int pHead2Length = GetListLength(pHead2);
            int lengthDif = pHead1Length - pHead2Length;
            if (pHead1Length <pHead2Length)
            {
                listNodeLong = pHead2;
                listNodeShort = pHead1;
                lengthDif = pHead2Length - pHead1Length;
            }
            for (int i = 0; i < lengthDif; i++)
            {
                listNodeLong = listNodeLong.next;
            }
            while (listNodeLong!= null && listNodeShort != null && listNodeLong != listNodeShort)
            {
                listNodeLong = listNodeLong.next;
                listNodeShort = listNodeShort.next;
            }
            return listNodeLong;
        }

        public int GetListLength(ListNode listNode)
        {
            int count = 0;
            ListNode temp = listNode;
            while (temp != null)
            {
                count ++;
                temp = temp.next;
            }
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode1 = new ListNode(1);
            ListNode listNode2 = new ListNode(2);
            ListNode listNode3 = new ListNode(3);
            ListNode listNode6 = new ListNode(6);
            ListNode listNode7 = new ListNode(7);
            ListNode listNode4 = new ListNode(4);
            ListNode listNode5 = new ListNode(5);
            listNode1.next = listNode2;
            listNode2.next = listNode3;
            listNode3.next = listNode6;
            listNode6.next = listNode7;
            listNode4.next = listNode5;
            listNode5.next = listNode6;
            Solution s = new Solution();
            ListNode listNode = s.FindFirstCommonNode(listNode1, listNode4);
        }
    }
}
