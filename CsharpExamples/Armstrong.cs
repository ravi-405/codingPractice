using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    class Armstrong
    { 
        static void Main()
        {
            // 153 is armstrong number
            // Sum of the cubes of its digits equal to number itself
            int r, q, temp; int sum = 0;
            Console.Write("Enter Number :- ");
            q = Convert.ToInt16(Console.ReadLine());
            temp = q;
            while(q!=0)
            {
                r = q % 10;               
                sum = sum + (r * r * r);
                q = q / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("{0} is armstrong number",temp);
            }
            else
            {
                Console.WriteLine("{0} is not armstrong number", temp);
            }
            Console.ReadLine();
        }
    }
}
