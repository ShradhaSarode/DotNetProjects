using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public partial class Calculator
    {
        public int Sub(int a,int b)
        {
            return a - b;
        }
        public void Mul(int a, int b)
        {
            int res = a * b;
            Print(res);
        }
        partial void Print(int c)
        {
            Console.WriteLine($"Result ={c}");
        }

    }
}
