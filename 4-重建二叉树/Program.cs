using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_重建二叉树
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

        public static TreeNode reConstructBinaryTree(int[] pre, int[] tin)
        {
            // write code here
            TreeNode root = reConstructbinaryTree(pre, 0, pre.Length - 1, tin, 0, tin.Length - 1);
            return root;
        }

        private static TreeNode reConstructbinaryTree(int[] preorder, int startPreorder, int endPreorder, int[] inorder,
            int startInorder, int endInorder)
        {
            if (startPreorder > endPreorder || startInorder > endInorder)
            {
                return null;
            }
            TreeNode root= new TreeNode(preorder[startPreorder]);
            for (int i = startInorder; i <= endInorder; i++)
            {
                if (inorder[i] == preorder[startPreorder])
                {
                    root.left = reConstructbinaryTree(preorder, startPreorder + 1, startPreorder + i - startInorder,
                        inorder, startInorder, i - 1);
                    root.right = reConstructbinaryTree(preorder, i - startInorder + startPreorder + 1, endPreorder,
                        inorder, i + 1, endInorder);
                }
            }
            return root;
        }
        static void Main(string[] args)
        {
            int[] a = new[] {1, 2, 4, 7, 3, 5, 6, 8};
            int[] b = new[] {4, 7, 2, 1, 5, 3, 8, 6};
            TreeNode t = reConstructBinaryTree(a, b);

            Console.ReadKey();
        }
    }
}
