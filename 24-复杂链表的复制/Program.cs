using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 输入一个复杂链表（每个节点中有节点值，以及两个指针，一个指向下一个节点，另一个特殊指针指向任意一个节点）
 * 解决思想：
 * 整个过程要分3步骤：
 * 1-复制原始链表的任意节点N并创建新节点N',N'链接到N的后面
 * 2-设置复制出来节点的m-Psibling
 * 3-长链表拆分成两个
 */
namespace _24_复杂链表的复制
{
    class Program
    {
        public class RandomListNode
        {
            public int label;
            public RandomListNode next, random;
            public RandomListNode(int x)
            {
                this.label = x;
            }
        }
        /// <summary>
        /// 正解答案1
        /// </summary>
        class Solution1
        {
            public RandomListNode Clone(RandomListNode pHead)
            {
                // write code here
                if (pHead == null)
                    return null;

                CloneNodes(pHead);
                CloneRandom(pHead);
                return sepreate(pHead);
            }
            private static void CloneNodes(RandomListNode pHead)
            {
                RandomListNode node = pHead;
                while (node != null)
                {
                    RandomListNode Clonenode = new RandomListNode(0);
                    Clonenode.label = node.label;
                    Clonenode.next = node.next;
                    Clonenode.random = null;

                    node.next = Clonenode;
                    node = Clonenode.next;
                }
            }
            private static void CloneRandom(RandomListNode pHead)
            {
                RandomListNode node = pHead;
                while (node != null)
                {
                    RandomListNode clone = node.next;
                    if (node.random != null)
                    {
                        clone.random = (node.random).next;
                    }
                    node = clone.next;
                }
            }

            private static RandomListNode sepreate(RandomListNode pHead)
            {
                RandomListNode cloneHead, cloneNode, node;


                node = pHead;
                cloneHead = cloneNode = node.next;
                node.next = cloneNode.next;
                node = node.next;

                while (node != null)
                {
                    cloneNode.next = node.next;
                    cloneNode = cloneNode.next;
                    node.next = cloneNode.next;
                    node = node.next;
                }
                return cloneHead;
            }
        }
        /// <summary>
        /// 这种解法提交总是有问题，提示没有处理多个实例
        /// </summary>
        class Solution
        {
            public RandomListNode Clone(RandomListNode pHead)
            {
                // write code here
                if (pHead == null)
                {
                    return null;
                }
                CloneNodes(pHead);
                CloneRandom(pHead);
                return ReConnectNode(pHead);
            }

            public void CloneNodes(RandomListNode phead)
            {
                RandomListNode pNode = phead;
                while (pNode !=null)
                {
                    RandomListNode pClone = new RandomListNode(pNode.label);
                    pClone.next = pNode.next;
                    pNode.next = pClone;
                    pNode = pClone.next;
                }
            }

            public void CloneRandom(RandomListNode pHead)
            {
                RandomListNode pNode = pHead;
                while (pNode !=null)
                {
                    RandomListNode pClone = pNode.next;
                    if (pNode.random != null)
                    {
                        pClone.random = pNode.random.next;
                    }
                    pNode = pClone.next;
                }
            }

            public RandomListNode ReConnectNode(RandomListNode pHead)
            {
                RandomListNode cloneHead,cloneNode, node;
                node = pHead;
                cloneHead =cloneNode= node.next;
                while (cloneHead.next!=null)
                {
                    node = cloneHead.next;
                    cloneHead.next = node.next;
                    cloneHead = cloneHead.next;

                }
                //cloneHead = pHead.next;
                return cloneNode;
            }
        }
        static void Main(string[] args)
        {
            RandomListNode randomListNode1 = new RandomListNode(1);
            RandomListNode randomListNode2 = new RandomListNode(2);
            RandomListNode randomListNode3 = new RandomListNode(3);
            RandomListNode randomListNode4 = new RandomListNode(4);
            RandomListNode randomListNode5 = new RandomListNode(5);
            randomListNode1.next = randomListNode2;
            randomListNode2.next = randomListNode3;
            randomListNode3.next = randomListNode4;
            randomListNode4.next = randomListNode5;
            randomListNode1.random = randomListNode3;
            randomListNode2.random = randomListNode5;
            randomListNode4.random = randomListNode2;
            Solution s = new Solution();
            RandomListNode randomListNode = s.Clone(randomListNode1);

        }
    }
}
