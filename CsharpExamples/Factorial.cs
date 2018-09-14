using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    class Factorial
    {
        //// Recursive method 
        //// Recursive function is a function that calls itself
        /*      public static double Fact(int n)
              {
                  if (n == 0)
                  {
                      return 1;
                  }

                  return n * Fact(n - 1);
              } */
        static void Main()
        {
            //// Normal program
            int n, fact = 1;
            Console.Write("Enter number that to factorial:-");
            n = int.Parse(Console.ReadLine());
            for (int c = n; c >= 1; c--)
            {
                if (n <= 1)
                {
                    fact = 1;
                }
                else
                {
                    fact = fact * c;
                }
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
