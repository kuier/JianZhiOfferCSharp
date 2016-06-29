using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 输入一个整数数组，判断该数组是不是某二叉搜索树的后序遍历的结果。如果是则输出Yes,否则输出No。假设输入的数组的任意两个数字都互不相同。
 */
namespace _22_二叉搜索树的后序遍历序列
{
    class Program
    {
        class Solution
        {
            public bool VerifySquenceOfBST(int[] sequence)
            {
                // write code here
                //边界
                if (sequence == null ||sequence.Length <= 0)
                {
                    return false;
                }
                if (sequence.Length == 1)
                {
                    return true;
                }
                //得到根节点
                int root = sequence[sequence.Length - 1];
                //找到了左子树的序号,0到i-1全是左子树
                int i = 0;
                for (; i < sequence.Length; i++)
                {
                    if (sequence[i]>root)
                    {
                        break;
                    }
                }
                //判断右子树里面是不是由比根节点小的，小得话返回false
                int j = i;
                for (; j < sequence.Length-1; j++)
                {
                    if (sequence[j] < root)
                    {
                        return false;
                    }
                }
                bool left = true;
                if (i>0)
                {
                    int[] leftInts = new int[i];
                    Array.Copy(sequence,0,leftInts,0,i);
                    left = VerifySquenceOfBST(leftInts);
                }
                bool right = true;
                if (i<sequence.Length-1)
                {
                    int[] rightInts = new int[sequence.Length - i - 1];
                    Array.Copy(sequence, i, rightInts, 0, sequence.Length - 1 - i);
                    right = VerifySquenceOfBST(rightInts);
                }
                return left && right;
            }
        }
        static void Main(string[] args)
        {
            int[] sequence = new[] {5, 7, 6, 9, 11, 10, 8};
            int[] sequence1 = new[] {7, 6, 5, 2};
            Solution s = new Solution();
            Console.WriteLine(s.VerifySquenceOfBST(sequence1));
            Console.ReadKey();
        }
    }
}
