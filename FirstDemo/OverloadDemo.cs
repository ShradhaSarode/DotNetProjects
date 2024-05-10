using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class OverloadDemo
    {
        static void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("1. Calculate Area of Triangle");
                Console.WriteLine("2. Calculate Area of Rectangle");
                Console.WriteLine("3. Calculate Area of Circle");
                Console.WriteLine("4. Calculate Area of Square");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CalculateArea();
                        break;
                    case 2:
                        CalculateArea(2);
                        break;
                    case 3:
                        CalculateArea(3.0);
                        break;
                    case 4:
                        CalculateArea(4, 4);
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 5);
        }

        static void CalculateArea()
        {
            Console.Write("Enter base of triangle: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height of triangle: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double area = 0.5 * b * h;
            Console.WriteLine("Area of Triangle: " + area);
        }

        static void CalculateArea(int choice)
        {
            Console.Write("Enter length of rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            double area = length * width;
            Console.WriteLine("Area of Rectangle: " + area);
        }

        static void CalculateArea(double choice)
        {
            Console.Write("Enter radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of Circle: " + area);
        }

        static void CalculateArea(int choice1, int choice2)
        {
            Console.Write("Enter side of square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            double area = side * side;
            Console.WriteLine("Area of Square: " + area);
        }
    }
    }

