using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_替换空格
{
    class Program
    {
         public static string replaceSpace(string str)
         {
             if (str==null)
             {
                 return null;
             }
             int originalLength = 0;
             int numberOfBlank = 0;
             for (int i = 0; i < str.Length; i++)
             {
                 originalLength ++;
                 if (str[i]==' ')
                 {
                     numberOfBlank ++;
                 }
             }
             int newLength = originalLength + 2*numberOfBlank;
             if (numberOfBlank ==0)
             {
                 return str;
             }
             int indexOfOriginal = originalLength-1;
             int indexOfNew = newLength-1;
             char[] newArray = new char[newLength];
             while (indexOfOriginal >=0)
             {
                 if (str[indexOfOriginal] == ' ')
                 {
                     newArray[indexOfNew--] = '0';
                     newArray[indexOfNew--] = '2';
                     newArray[indexOfNew--] = '%';
                 }
                 else
                 {
                     newArray[indexOfNew--] = str[indexOfOriginal];
                 }
                 --indexOfOriginal;
             }
             string s = new string(newArray);
             return s;
         }

        public static string replaceSpace1(string str)
        {
            return str.Replace(" ","%20");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(replaceSpace1("we are happy"));
            Console.Read();
        }
    }
}
