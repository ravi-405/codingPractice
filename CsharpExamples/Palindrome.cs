using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    class Palindrome
    {        
        static void Main()
        {
            // 121 is palindrome
            // It remains the same when digits are reversed
            int r, q, temp, sum = 0;
            Console.Write("Enter Number :- ");
            q = Convert.ToInt16(Console.ReadLine());
            temp = q;
            while(q!=0)
            {
                r = q % 10;
                sum = (sum * 10)+ r;
                q = q / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("{0} is palindrome", temp);
            }
            else
            {
                Console.WriteLine("{0} is not palindrome", temp);
            }
            Console.ReadLine();
        }
    }
}
