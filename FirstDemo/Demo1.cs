using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class Demo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int add = n1 + n2;
            Console.WriteLine("Addition is: "+add);
            
        }
    }
}
