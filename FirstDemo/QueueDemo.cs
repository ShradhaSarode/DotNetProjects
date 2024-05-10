using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class QueueDemo
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("Hello");
            queue.Enqueue("Good Morning");
            queue.Enqueue("Bye");

            //remove --> first element will be removed "Hello"
            queue.Dequeue();

            // select first element
            Console.WriteLine($"first element in the queue {queue.Peek()}");
            // to get total elements
            Console.WriteLine($"total elements {queue.Count}");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
