using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 输入两颗二叉树A，B，判断B是不是A的子结构。
 */

namespace _16_树的子树
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
            public bool HasSubtree(TreeNode pRoot1, TreeNode pRoot2)
            {
                // write code here
                bool result = false;
                if (pRoot1 != null && pRoot2 != null)
                {
                    //找到相等的根节点
                    if (pRoot1.val == pRoot2.val)
                    {
                        result = DoesTreeHaveTree2(pRoot1, pRoot2);
                    }
                    if (!result)
                    {
                        result = HasSubtree(pRoot1.left, pRoot2);
                    }
                    if (!result)
                    {
                        result = HasSubtree(pRoot1.right, pRoot2);
                    }
                }
                return result;
            }

            public bool DoesTreeHaveTree2(TreeNode pRoot1, TreeNode pRoot2)
            {
                if (pRoot2 == null)
                {
                    return true;
                }
                if (pRoot1 == null)
                {
                    return false;
                }
                if (pRoot1.val != pRoot2.val)
                {
                    return false;
                }
                return DoesTreeHaveTree2(pRoot1.left,pRoot2.left)&&DoesTreeHaveTree2(pRoot1.right,pRoot2.right);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
