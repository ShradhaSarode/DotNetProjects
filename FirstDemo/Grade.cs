using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class Grade
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
            double percentage = totalMarks / 5.0;

            Console.WriteLine("Total Marks: " + totalMarks);
            Console.WriteLine("Percentage: " + percentage);
            string grade = GetGrade(percentage);
            Console.WriteLine("Grade: "+grade);
        }
        static string GetGrade(double percentage)
        {
            if (percentage >= 90)
                return "A+";
            else if (percentage >= 80)
                return "A";
            else if (percentage >= 70)
                return "B";
            else if (percentage >= 60)
                return "C";
            else if (percentage >= 50)
                return "D";
            else
                return "Fail";
        }
    }
}
