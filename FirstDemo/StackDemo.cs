using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class StackDemo
    {
        public static void Main(String[] args)
        {
            Stack st = new Stack();

            st.Push(10);
            st.Push(20);
            st.Push(30);

            // to remove top element
            st.Pop();

            Console.WriteLine($"Top element on stack {st.Peek()}");
            Console.WriteLine($"Total elements {st.Count}");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

        }
    }
}
