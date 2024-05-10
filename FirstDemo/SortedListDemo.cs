using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class SortedListDemo
    {
        public static void Main(string[] args)
        {
            SortedList list = new SortedList();

            list.Add(104, "HR");
            list.Add(103, "Sales");
            list.Add(101, "Development");
            list.Add(102, "Testing");
            list.Add(105, "IT");
            list.Add(107, "Finance");
            list.Add(106, "CS");

            list.Remove(104);
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
