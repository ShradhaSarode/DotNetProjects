using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class TernaryOp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any numbber: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string result = (num > 0) ? "Positive" : (num < 0) ? "Negative" : "Zero";

            Console.WriteLine("The number is : "+result);
        }
    }
}
