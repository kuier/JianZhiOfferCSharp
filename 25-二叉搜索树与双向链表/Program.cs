using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 输入一棵二叉搜索树，将该二叉搜索树转换成一个排序的双向链表。要求不能创建任何新的结点，只能调整树中结点指针的指向。
 */
namespace _25_二叉搜索树与双向链表
{
    class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x)
            {
                val = x;
            }
        }
        class Solution
        {
            public TreeNode Convert(TreeNode pRootOfTree)
            {
                // write code here
                TreeNode pLastNodeInList = null;
                ConvertNode(pRootOfTree,ref pLastNodeInList);
                //pLastNodeInList指向双向链表的尾节点，我们需要返回头节点
                TreeNode pHeadNodeInList = pLastNodeInList;
                while (pHeadNodeInList != null && pHeadNodeInList.left != null)
                {
                    pHeadNodeInList = pHeadNodeInList.left;
                }
                return pHeadNodeInList;
            }

            private void ConvertNode(TreeNode pRootOfTree,ref TreeNode pLastNodeInList)
            {
                if (pRootOfTree == null)
                {
                    return; 
                }
                TreeNode pCurrent = pRootOfTree;
                if (pCurrent.left != null)
                {
                    ConvertNode(pCurrent.left,ref pLastNodeInList);
                }
                pCurrent.left = pLastNodeInList;
                if (pLastNodeInList!=null)
                {
                    pLastNodeInList.right = pCurrent;
                }
                pLastNodeInList = pCurrent;
                if (pCurrent.right != null)
                {
                    ConvertNode(pCurrent.right,ref pLastNodeInList);
                }
            }
        }
        static void Main(string[] args)
        {
            TreeNode node1 = new TreeNode(10);
            TreeNode node2 = new TreeNode(6);
            TreeNode node3 = new TreeNode(14);
            TreeNode node4 = new TreeNode(4);
            TreeNode node5 = new TreeNode(8);
            TreeNode node6 = new TreeNode(12);
            TreeNode node7 = new TreeNode(16);
            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            node3.right = node7;
            Solution s = new Solution();
            TreeNode treeNode = s.Convert(node1);
        }
    }
}
