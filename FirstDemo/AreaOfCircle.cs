using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class AreaOfCircle
    {
        static void Main(string[] args)
        {
            double radius;
            double area;

            Console.WriteLine("Enter radius of circle: ");
             radius = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * Math.Pow(radius,2);
            Console.WriteLine("Area of circle : "+area);

        }
    }
}
