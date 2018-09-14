using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsharpExamples
{
    class RecursiveReal
    {

        //// To find all folder files and sub-folder files
        public static void Main()
        {
            Console.Write("Enter the path : ");
            string path = Console.ReadLine();
            findfiles(path);
        }
        public static void findfiles(string path)
        {           
                foreach (string filename in Directory.GetFiles(path))
                {
                    Console.WriteLine(filename);
                }

                foreach (string directory in Directory.GetDirectories(path))
                {
                    findfiles(directory);
                }            
            Console.ReadLine();
        }
    }
}
