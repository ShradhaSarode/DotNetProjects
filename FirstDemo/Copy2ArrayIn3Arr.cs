using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class Copy2ArrayIn3Arr
    {
        public static void Main()
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] array3 = MergeArrays(array1,array2);
            Console.WriteLine("Merged array:");
            foreach (int a3 in array3)
            {
                Console.WriteLine(a3);
            }
        }
       
        static int[] MergeArrays(int[] array1, int[] array2)
        {
            return array1.Concat(array2).ToArray();
        }
    }
}
