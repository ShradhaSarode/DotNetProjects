using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
     public class MyClass
    {
        public static int staticVariable;   
        static MyClass()
        {
            Console.WriteLine("Static constructor called.");
            staticVariable = 100; 
        }  
        public static void StaticMethod()
        {
            Console.WriteLine("Static method called.");
        }
        public void InstanceMethod()
        {
            Console.WriteLine("Instance method called.");
        }
    }
    public class StaticKeyword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static variable value: " + MyClass.staticVariable);
            MyClass.StaticMethod();
            MyClass myObject = new MyClass(); 
            Console.WriteLine("Static variable value through an instance: " + MyClass.staticVariable);
            MyClass.StaticMethod();  
            myObject.InstanceMethod();
        }
    }
}
