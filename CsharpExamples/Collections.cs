using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    class Collections
    {
        static void Main()
        {
            /*   ArrayList al = new ArrayList();
               al.Add(1);
               al.Add("two");
               al.Add(true);
               al.Add("Hai Ravi");            
               foreach(var val in al)
               {
                   Console.WriteLine(val);
               }  

               Hashtable ht = new Hashtable();
               ht.Add(1, "one");
               ht.Add(2, "two");
               ht.Add(3, "ravi");
               string value = (string)ht[4];
               Console.WriteLine(value);
               foreach (var val in ht.Values)
               {
                   Console.WriteLine(val.ToString());
               } 

            SortedList sl = new SortedList();
            sl.Add(1, "one");
            sl.Add(2, "two");
            sl.Add(4, "four");
            sl.Add(3, "three");
            foreach(var val in sl.Values)
            {
                Console.WriteLine(val);
            }
             
            // generic dictionary
            IDictionary<int,string> id = new Dictionary<int, string>();
            id.Add(1, "one");
            id.Add(2, "two");
            id.Add(3, "three");
            foreach (KeyValuePair<int, string> value in id)
            {
                Console.WriteLine(value.Key +"-----" + value.Value);
            }    */

            // Non-generic dictionary

            IDictionary id1 = new Dictionary<int,string>();
            id1.Add(1, "one1");
            id1.Add(2, "two2");
            id1.Add(3, "three3");
            foreach (var value in id1.Values)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
