using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 题目描述：输入一个链表，输出该链表中倒数第k个结点。
 */

namespace _13_链表中倒数第K个节点
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
            public ListNode FindKthToTail(ListNode head, int k)
            {
                // write code here
                if (head == null || k ==0)
                {
                    return null;   
                }
                ListNode pAhead = head;
                ListNode pBehind = null;
                for (int i = 0; i < k-1; i++)
                {
                    if (pAhead.next != null)
                    {
                        pAhead = pAhead.next;
                        continue;
                    }
                    return null;
                }
                pBehind = head;
                while (pAhead.next !=null)
                {
                    pAhead = pAhead.next;
                    pBehind = pBehind.next;
                }
                return pBehind;
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
            ListNode node=  s.FindKthToTail(listNode1, 3);
        }
    }
}
