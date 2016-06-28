using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 题目描述：输入两个单调递增的链表，输出两个链表合成后的链表，当然我们需要合成后的链表满足单调不减规则。
 */
namespace _15_合并两个排序的链表
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
            public ListNode Merge(ListNode pHead1, ListNode pHead2)
            {
                // write code here
                if (pHead1 == null)
                {
                    return pHead2;
                }
                if (pHead2==null)
                {
                    return pHead1;
                }
                ListNode pMergeHead = null;
                if (pHead1.val < pHead2.val)
                {
                    pMergeHead = pHead1;
                    pMergeHead.next = Merge(pHead1.next, pHead2);
                }
                else
                {
                    pMergeHead = pHead2;
                    pMergeHead.next = Merge(pHead1, pHead2.next);
                }
                return pMergeHead;
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
        }
    }
}
