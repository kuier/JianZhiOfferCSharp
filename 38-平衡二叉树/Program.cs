using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 输入一棵二叉树，判断该二叉树是否是平衡二叉树。
 */
namespace _38_平衡二叉树
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
            public int TreeDepth(TreeNode pRoot)
            {
                // write code here
                if (pRoot == null)
                {
                    return 0;
                }
                int nLeft = TreeDepth(pRoot.left);
                int nRight = TreeDepth(pRoot.right);
                return (nLeft > nRight) ? nLeft + 1 : nRight + 1;
            }
            public bool IsBalanced_Solution(TreeNode pRoot)
            {
                // write code here
                if (pRoot == null)
                {
                    return true;
                }
                int left = TreeDepth(pRoot.left);
                int right = TreeDepth(pRoot.right);
                if (Math.Abs(left-right)>1)
                {
                    return false;
                }
                return IsBalanced_Solution(pRoot.left) && IsBalanced_Solution(pRoot.right);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
