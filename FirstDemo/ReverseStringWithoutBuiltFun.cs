using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class ReverseStringWithoutBuiltFun
    {
        static void Main(string[] args)
        {
            string input = "Hello, world!"; // Example string to reverse
            string reversed = ReverseString(input);

            Console.WriteLine($"Original string: {input}");
            Console.WriteLine($"Reversed string: {reversed}");
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray(); // Convert the string to a character array
            int start = 0;
            int end = input.Length - 1;

            // Swap characters from start to end
            while (start < end)
            {
                // Swap characters at start and end positions
                char temp = charArray[start];
                charArray[start] = charArray[end];
                charArray[end] = temp;

                // Move start pointer forward and end pointer backward
                start++;
                end--;
            }

            // Convert the reversed character array back to a string
            return new string(charArray);
        }
    }
}
