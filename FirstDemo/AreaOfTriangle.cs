using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base of the triangle: ");
            double base1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * base1 * height;
            Console.WriteLine("The area of the triangle is: " + area);
        }
    }
}
