using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class Percentage
    {
        static void Main(string[] args)
        {
            int s1, s2, s3, s4, s5;
            Console.WriteLine("Enter marks for 5 subject: ");

            Console.Write("Subject 1: ");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Subject 2: ");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Subject 3: ");
            s3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Subject 4: ");
            s4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Subject 5: ");
            s5 = Convert.ToInt32(Console.ReadLine());

            int totalMarks = s1 + s2 + s3 + s4 + s5;
            double avg = totalMarks / 5.0;

            Console.WriteLine("Total Marks: "+totalMarks);
            Console.WriteLine("Percentage: "+avg);

        }
    }
}
