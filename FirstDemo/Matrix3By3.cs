using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class Matrix3By3
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[3, 3];
        int[,] matrix2 = new int[3, 3];
        int[,] result = new int[3, 3];

        
        Console.WriteLine("Enter elements of first matrix:");
        for (int i = 0; i< 3; i++)
        {
            for (int j = 0; j< 3; j++)
            {
                Console.Write($"Enter element [{i+1},{j+1}]: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("\nEnter elements of second matrix:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Enter element [{i + 1},{j + 1}]: ");
        matrix2[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        result[i, j] = matrix1[i, j] + matrix2[i, j];
    }
}

Console.WriteLine("\nResultant Matrix:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}
    }
    }
}
