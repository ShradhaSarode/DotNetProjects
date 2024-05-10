using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Q.write a code contain 1 abstract class and abstract class having int variable 
create a interface  which also contain variable as int type
perform addition of 2 variable in child class*/
namespace FirstDemo
{
    abstract class AbstractClass
    {
        protected int number; 
        public abstract void Display();
    }
    interface IAddition
    {
        static int secondNumber { get; set; }
    }
    class ChildClass : AbstractClass, IAddition
    {
        public  int secondNumber { get; set; }
        public ChildClass(int num)
        {
            number = num;
        }
        public override void Display()
        {
            Console.WriteLine($"First number: {number}");
        }
        public int PerformAddition()
        {
            return number + IAddition.secondNumber;
        }
    }
    public class AbstractInterface
    {
        static void Main(string[] args)
        {
            ChildClass child = new ChildClass(10);
            child.secondNumber = 20;
            child.Display();
            int result = child.PerformAddition();
            Console.WriteLine($"Addition result: {result}");
        }
    }
}
