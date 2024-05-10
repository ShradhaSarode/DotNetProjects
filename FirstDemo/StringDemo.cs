using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class StringDemo
    {
        public static void Main(string[] args)
        {
            string str = "Hello to all";
            string str2 = "Hello";
            // need to convert string to char[]

            char[] chs = str.ToCharArray();
            foreach (var item in chs)
            {
                Console.WriteLine(item);
            }
            //split  --> string to string[] using condition

            string[] result = str.Split(' ');

            // result[0]="Hello"
            // result[1]="to"
            //result[2]="all"

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            if (string.IsNullOrEmpty(str2))
            {
                Console.WriteLine("string is empty or null");
            }
            else
            {
                Console.WriteLine(str2);
            }



            string str1 = "Hello";

            Console.WriteLine(str1);
            Console.WriteLine($"address of str {str.GetHashCode()}");// object class method

            str1 = "hello Hi";
            Console.WriteLine("---after changed value");
            Console.WriteLine(str1);
            Console.WriteLine($"address of str {str.GetHashCode()}");

            str1 = str1 + " good morning";
            Console.WriteLine("---after changed value");
            Console.WriteLine(str1);
            Console.WriteLine($"address of str {str.GetHashCode()}");


        }
    }
}
