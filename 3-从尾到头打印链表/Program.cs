using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_从尾到头打印链表
{
    class Program
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode (int x)
            {
                val = x;
            }
        }
        public List<int> printListFromTailToHead(ListNode listNode)
        {
            // write code here
            List<int> originaList = new List<int>();
            List<int> printList = new List<int>();
            ListNode node = listNode;
            while (node != null)
            {
                originaList.Add(node.val);
                node = node.next;
            }
            for (int i = originaList.Count-1; i >=0; i--)
            {
                printList.Add(originaList[i]);
            }
            return printList;
        }
        static void Main(string[] args)
        {
        }
    }
}
