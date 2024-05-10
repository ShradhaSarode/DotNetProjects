using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class OverloadStatic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition: " + PerformOperation(5, 3));
            Console.WriteLine("Subtraction: " + PerformOperation(5, 3, '-'));
            Console.WriteLine("Multiplication: " + PerformOperation(5, 3, "*"));
            Console.WriteLine("Division: " + PerformOperation(5.0, 3.0));
        }
        public static int PerformOperation(int a,int b)
        {
            return a + b;
        }
        public static int PerformOperation(int a, int b,char operation)
        {
            if (operation == '-')
                return a - b;
            else
                throw new ArgumentException("Invalid Operation");
        }
        // Multiplication
        public static int PerformOperation(int a, int b, string operation)
        {
            if (operation == "*")
                return a * b;
            else
                throw new ArgumentException("Invalid operation");
        }

        // Division
        public static double PerformOperation(double a, double b)
        {
            return a / b;
        }
    }
}
