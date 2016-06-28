using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 操作给定的二叉树，将其变换为源二叉树的镜像。
 */
namespace _17_二叉树的镜像
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
            public TreeNode Mirror(TreeNode root)
            {
                // write code here
                if (root == null)
                {
                    return null;
                }
                if (root.left == null && root.right == null)
                {
                    return null;
                }

                TreeNode temp = root.right;
                root.right = root.left;
                root.left = temp;

                if (root.left != null)
                {
                    Mirror(root.left);
                }
                if (root.right != null)
                {
                    Mirror(root.right);
                }
                return root;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
