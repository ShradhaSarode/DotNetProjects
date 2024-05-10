using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class StringBuilderDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------StringBuilder class");

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            Console.WriteLine(sb);
            Console.WriteLine($"address of sb {sb.GetHashCode()}");

            Console.WriteLine("-----after changed the value");
            sb.Append("Hello to all");
            Console.WriteLine(sb);
            Console.WriteLine($"address of sb {sb.GetHashCode()}");


            sb.Clear();
            //sb.Length; // to get total characters . i.e. length of string

        }
    }
}
