using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class MaxNo
    {
        static void Main(string[] args)
        {
            
            int[] numbers = { 34, 12, 89, 45, 67, 23, 56, 78, 99, 18 };

            
            int max = numbers[0];

            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i]; 
                }
            }

            
            Console.WriteLine($"The maximum number among the given numbers is: {max}");
        }
    }
}
