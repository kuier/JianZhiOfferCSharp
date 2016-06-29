using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 从上往下打印出二叉树的每个节点，同层节点从左至右打印
 * 
 */
namespace _21_从上往下打印二叉树
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
            public List<int> PrintFromTopToBottom(TreeNode root)
            {
                // write code here
                List<int> list = new List<int>();
                Queue<TreeNode> helpQueue = new Queue<TreeNode>();
                if (root == null)
                {
                    return list;
                }
                helpQueue.Enqueue(root);
                while (helpQueue.Count !=0)
                {
                    TreeNode node = helpQueue.Dequeue();
                    list.Add(node.val);
                    if (node.left!=null)
                    {
                        helpQueue.Enqueue(node.left);
                    }
                    if (node.right !=null)
                    {
                        helpQueue.Enqueue(node.right);
                    }
                }
                return list;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
