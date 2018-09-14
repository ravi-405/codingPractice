using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Constructor Called");
        }
        public void ParentChild()
        {
            Console.WriteLine("Parent Class method called");
        }
        static void Main()
        {
            ParentClass p = new ParentClass();
            p.ParentChild();
            Console.ReadLine();
        }
    }
}
