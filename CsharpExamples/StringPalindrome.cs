using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    class StringPalindrome
    {
        //To determine whether a word is a palindrome or not .
        static void Main()
        {
            string strRev, strReal = null;
            Console.WriteLine("Enter the string..");
            strReal = Console.ReadLine();
            char[] tmpChar = strReal.ToCharArray();
            Array.Reverse(tmpChar);
            strRev = new string(tmpChar);
            if (strReal.Equals(strRev, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The string is pallindrome");
            }
            else
            {
                Console.WriteLine("The string is not pallindrome");
            }
            Console.ReadLine();
        }
    }
}
