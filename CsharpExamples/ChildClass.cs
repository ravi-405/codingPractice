using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("Child Constructor Called");
        }
        public new void  ParentChild()
        {
            Console.WriteLine("Child Class method called");
        }
        static void Main()
        {
            ParentClass c = new ChildClass();
            c.ParentChild();
            Console.ReadLine();             
        }
    }
}
