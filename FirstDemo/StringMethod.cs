using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class StringMethod
    {
        public static void Main(string[] args)
        {
            String st = "I Love My India.";
            String st1 = "India is My Country.";
            Console.WriteLine("string is empty or null: "+ String.IsNullOrEmpty(st));
            Console.WriteLine("Concat the 2 string: "+ String.Concat(st,st1));
            Console.WriteLine("To char array: " + st.ToCharArray());
            Console.WriteLine("To upper case: " + st.ToUpper());
            Console.WriteLine("To lower case: " + st.ToLower());
            char charAtIndex3 = CharAt(st, 3);
            Console.WriteLine($"Character at index 3: {charAtIndex3}");
            int indexOfO = IndexOf(st, 'o');
            Console.WriteLine($"Index of 'o': {indexOfO}");

            static char CharAt(string str, int index)
            {
                if (index >= 0 && index < str.Length)
                {
                    return str[index];
                }
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            static int IndexOf(string str, char c)
            {
                return str.IndexOf(c);
            }

            int lastIndexOfO = LastIndexOf(st, 'o');
            Console.WriteLine($"Last index of 'o': {lastIndexOfO}");

            
            string substring = Substring(st, 7, 5);
            Console.WriteLine($"Substring from index 7 with length 5: {substring}");

            
            bool containsWorld = Contains(st, "My");
            Console.WriteLine($"Contains 'World': {containsWorld}");

            
            string[] parts = Split(st, ',');
            Console.WriteLine($"Split string by comma: {string.Join(", ", parts)}");

            
            string trimmedStr = Trim("   I Love My India.   ");
            Console.WriteLine($"Trimmed string: '{trimmedStr}'");
        }
        static int IndexOf(string str, char c)
        {
            return str.IndexOf(c);
        }

        static int LastIndexOf(string str, char c)
        {
            return str.LastIndexOf(c);
        }

        static string Substring(string str, int startIndex, int length)
        {
            return str.Substring(startIndex, length);
        }

        static bool Contains(string str, string substring)
        {
            return str.Contains(substring);
        }

        static string[] Split(string str, char separator)
        {
            return str.Split(separator);
        }

        static string Trim(string str)
        {
            return str.Trim();
        }
    }
}
