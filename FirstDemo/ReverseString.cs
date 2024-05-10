using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class ReverseString
    {
        static void Main(string[] args)
        {
            string input = "Hello, world!"; 
            string reversed = Reverse(input);

            Console.WriteLine($"Original string: {input}");
            Console.WriteLine($"Reversed string: {reversed}");
        }

        static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray(); 
            Array.Reverse(charArray); 
            return new string(charArray); 
        }
    }
}
