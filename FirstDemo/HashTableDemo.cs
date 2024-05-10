using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class HashTableDemo
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(91, "IND");
            ht.Add(1, "USA");
            ht.Add(63, "AUS");
            ht.Add(446, "MAC");
            ht.Add(124, "CAN");
            ht.Add(198, "EUN");
            ht.Add(380, "ITA");

            ht.Remove(63); // remove is based on key

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
