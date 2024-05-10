using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class ArrayListDemo
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 15, 22, 38 };

            ArrayList list = new ArrayList(); // u can also set the default initial value of ArrayList

            // methods of ArrayList

            //list.Add(10);
            //list.Add(56.66);
            //list.Add("Hello");
            //list.Add(new Product { Id = 1, Name = "Pen", Price = 10 });


            list.Add(45);
            list.Add(88);
            list.Add(11);
            list.AddRange(arr);
            list.Insert(1, 22);

            //list.RemoveAt(2); // 2 is index
            //list.Remove(20); // remove based on object / element present in the collection
            //list.RemoveRange(1, 3);// remove multiple values from collections

            //list.Clear(); // clear list at once

            list.Sort();//asc
            list.Reverse();//desc
            Console.WriteLine($"Total elements in list = {list.Count}");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
