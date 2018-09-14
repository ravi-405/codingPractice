using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    class Febonacci
    {       
        static void Main()
        {
            int c, first = 0, second = 1, n, next;
            Console.WriteLine("Enter the number of terms");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("First {0} no. of fibonacci series are", n);
            for (c=0; c<n; c++)
            {
                if (c <= 1)
                {
                    next = c;
                }
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                }
                Console.WriteLine(next);           
            }
            Console.ReadLine();
        }
    }
}
