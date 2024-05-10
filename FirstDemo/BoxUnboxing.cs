using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class BoxUnboxing
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(10); // boxing Index - 0
            list.Add(20);  // boxing  Index - 1
            list.Add("Hello");
            // unbox
            int b = Convert.ToInt32(list[1]); // unboxing , explicit

            string str = list[2].ToString(); // unboxing, explicit

        }
    }
}
