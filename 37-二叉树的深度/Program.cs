using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_二叉树的深度
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
        }
        static void Main(string[] args)
        {
        }
    }
}
