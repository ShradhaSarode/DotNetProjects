using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class DisplayMsg
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i==3 && i==5)
                    Console.WriteLine("Welcome to Pune");
                else if(i%3==0)
                    Console.WriteLine("Pune");
                else if(i%5==0)
                    Console.WriteLine("Welcome");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
