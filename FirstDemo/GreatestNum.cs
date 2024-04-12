using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class GreatestNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num3: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int max = n1;
            if (n2 > max)
                max = n2;

            if (n3 > max)
                max = n3;

            Console.WriteLine("Greatest num is : "+max);
        }
    }
}
