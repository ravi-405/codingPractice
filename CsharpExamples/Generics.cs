using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
   static class Generics<T>
    {
        public static void Compare(T t1,T t2)
        {
        Console.WriteLine(t1.Equals(t2));
        }               
    }

   public class genericOperations
    { 
   public static void Main()
    {
            Generics<string>.Compare("Ravi","Ravi");
            Console.ReadLine();
    }
    }
}
