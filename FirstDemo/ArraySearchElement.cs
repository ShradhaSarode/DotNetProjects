using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Q.3.WAp to to search an element into the array 
namespace FirstDemo
{
    public class ArraySearchElement
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }; 
            int target = 12; 

            int index = SearchElement(numbers, target);

            if (index != -1)
            {
                Console.WriteLine($"Element {target} found at index {index}.");
            }
            else
            {
                Console.WriteLine($"Element {target} not found in the array.");
            }
        }

        static int SearchElement(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    return i; // Return the index if the target element is found
                }
            }

            return -1; // Return -1 if the target element is not found
        }
    }
}
