using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class StringBuilderMethod
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello, World!");
            sb.Remove(7, 7); 
            Console.WriteLine($"After Remove(): {sb}");
            sb.Replace("Hello", "Hi"); 
            Console.WriteLine($"After Replace(): {sb}");
            sb.Clear(); 
            Console.WriteLine($"After Clear(): {sb}");
            int capacity = sb.Capacity;
            Console.WriteLine($"Capacity: {capacity}");
            int length = sb.Length;
            Console.WriteLine($"Length: {length}");
        }
    }
}
