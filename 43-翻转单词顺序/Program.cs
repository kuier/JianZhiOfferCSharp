using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 翻转单词顺序列
 * 牛客最近来了一个新员工Fish，每天早晨总是会拿着一本英文杂志，写些句子在本子上。同事Cat对Fish写的内容颇感兴趣，有一天他向Fish借来翻看，但却读不懂它的意思。例如，“student. a am I”。后来才意识到，这家伙原来把句子单词的顺序翻转了，正确的句子应该是“I am a student.”。Cat对一一的翻转这些单词顺序可不在行，你能帮助他么？
 */
namespace _43_翻转单词顺序
{
    class Program
    {
        class Solution
        {
            /// <summary>
            /// 反转字符串，数组是引用类型
            /// </summary>
            /// <param name="array"></param>
            private void Reverse(char[] array,int pBegin,int pEnd)
            {
                while (pBegin<pEnd)
                {
                    char temp = array[pEnd];
                    array[pEnd] = array[pBegin];
                    array[pBegin] = temp;

                    pBegin++;
                    pEnd--;
                }
            }
            public string ReverseSentence(string str)
            {
                // write code here
                if (str == null)
                {
                    return null;
                }
                char[] array = str.ToCharArray();
                bool space = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == ' ')
                    {
                        space = true;
                        break;
                    }
                }
                if (!space)
                {
                    return str;
                }
                Reverse(array,0,array.Length-1);
                int pbegin = 0;
                int pEnd = array.Length - 1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == ' ')
                    {
                        pEnd = i-1;
                        Reverse(array,pbegin,pEnd);
                        pbegin = i+1;
                    }
                    else if (i == array.Length-1)
                    {
                        Reverse(array,pbegin,array.Length-1);
                    }
                }
                return new string(array);
            }
        }
        static void Main(string[] args)
        {
            Solution s=new Solution();
            Console.WriteLine(s.ReverseSentence("Ia am a student!"));

        }
    }
}
