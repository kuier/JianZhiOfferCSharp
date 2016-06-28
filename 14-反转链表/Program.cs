using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 题目描述：输入一个链表，反转链表后，输出链表的所有元素。
 */
namespace _14_反转链表
{
    class Program
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
        class Solution
        {
            public ListNode ReverseList(ListNode pHead)
            {
                if (pHead == null)
                {
                    return null;
                }
                if (pHead.next == null)
                {
                    return pHead;
                }
                // write code here
                ListNode reverseHead = null;
                ListNode pNode = pHead;
                ListNode prevNode = null;
                while (pNode != null)
                {
                    ListNode pnexNode = pNode.next;
                    if (pnexNode == null)
                    {
                        reverseHead = pNode;
                    }
                    pNode.next = prevNode;
                    prevNode = pNode;
                    pNode = pnexNode;
                }
                return reverseHead;
            }
        }
        static void Main(string[] args)
        {
            ListNode listNode1 = new ListNode(1);
            ListNode listNode2 = new ListNode(2);
            listNode1.next = listNode2;
            ListNode listNode3 = new ListNode(3);
            listNode2.next = listNode3;
            ListNode listNode4 = new ListNode(4);
            listNode3.next = listNode4;
            ListNode listNode5 = new ListNode(5);
            listNode4.next = listNode5;
            Solution s = new Solution();
            s.ReverseList(listNode1);
        }
    }
}
