using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class JaggedArrayDemo
    {
        public static void Main(string[] args)
        {
            int[][] arr = new int[4][];
            arr[0] = new int[] {10,20,30 };
            arr[1] = new int[] { 11, 22, 33,44,55 };
            arr[2] = new int[] { 101, 102, 103,104 };
            arr[3] = new int[] { 210, 220, 230,240,250,260 };

            foreach (int[] item in arr)
            {
                   foreach(int i in item)
                     {
                    Console.Write($"{i}");
                     }
                Console.WriteLine();
            }


        }
    }
}
