using System;
namespace CsharpExamples
{
    class Rectangle
    {
        double length;
        double width;
        public void AcceptDetails()
        {
            Console.WriteLine("Enter Num1 = {0}",length = Convert.ToDouble(Console.ReadLine()));           
            Console.WriteLine("Enter Num2 = {0}",width = Convert.ToDouble(Console.ReadLine()));          
        }
        public double GetArea()
        {
          return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length= {0}",length);
            Console.WriteLine("Width= {0}",width);
        }
    }
    class ExecuteRectangle
    { 
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.Display();
            Console.WriteLine(r.GetArea());
            Console.ReadLine();
        }
    }
}
