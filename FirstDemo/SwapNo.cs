using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class SwapNo
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Before swapping: a = {a}, b = {b}");

            
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After swapping: a = {a}, b = {b}");
        }
    }
}
