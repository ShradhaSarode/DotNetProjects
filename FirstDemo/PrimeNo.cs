using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class PrimeNo
    {
        static void Main(string[] args)
        {
            int number = 17; // Example number to check for primality

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            // Check divisibility from 2 to the square root of the number
            for (int i = 2; i <number; i++)
            {
                if (number % i == 0)
                {
                    return false; // Number is divisible by i, so it's not prime
                }
            }

            return true; // Number is not divisible by any number other than 1 and itself, so it's prime
        }
    }
}
