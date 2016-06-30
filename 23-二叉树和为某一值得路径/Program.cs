using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 输入一颗二叉树和一个整数，打印出二叉树中结点值的和为输入整数的所有路径。路径定义为从树的根结点开始往下一直到叶结点所经过的结点形成一条路径。
 */
namespace _23_二叉树和为某一值得路径
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
            private List<List<int>> pathAll = new List<List<int>>();
            private List<int> path = new List<int>();
            public List<List<int>> FindPath(TreeNode root, int expectNumber)
            {
                // write code here
                if (root == null) return pathAll;
                path.Add(root.val);
                expectNumber -= root.val;

                if (expectNumber == 0 && root.left == null && root.right == null)
                {
                    pathAll.Add(new List<int>(path));
                }

                FindPath(root.left, expectNumber);
                FindPath(root.right, expectNumber);

                path.RemoveAt(path.Count - 1);

                return pathAll;
            }


        }

        static void Main(string[] args)
        {
            TreeNode node1 = new TreeNode(10);
            TreeNode node2 = new TreeNode(5);
            TreeNode node3 = new TreeNode(4);
            TreeNode node4 = new TreeNode(7);
            TreeNode node5 = new TreeNode(12);
            node1.left = node2;
            node2.left = node3;
            node2.right = node4;
            node1.right = node5;

            Solution s = new Solution();
            Console.WriteLine(s.FindPath(node1,22));
        }
    }
}
