using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class EvenOdd
    {
        static void Main(string[] args)
        {
            int number = 7; // Example number to check

            if (IsEven(number))
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
