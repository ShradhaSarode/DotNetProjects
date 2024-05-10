using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Q.2.WAP to find out the some of prime number from array

namespace FirstDemo
{
    public class ArrayPrimeNoSum
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
                            //i <= Math.Sqrt(number)
            for (int i = 2; i <number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static int GetSumOfPrimes(int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    sum += number;
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 5, 6, 7, 11, 13, 17, 19, 23 }; // Sample array of numbers

            int sumOfPrimes = GetSumOfPrimes(numbers);

            Console.WriteLine($"Sum of prime numbers in the array: {sumOfPrimes}");
        }
    }

}
