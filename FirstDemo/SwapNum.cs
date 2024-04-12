using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class SwapNum
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;

            Console.WriteLine("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before swapping: num1 = {num1}, num2 = {num2}");

            // Swapping logic
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
        }
    }
}
