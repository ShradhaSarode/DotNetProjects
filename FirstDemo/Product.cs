using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class Product
    {
        private int code;
        private string name;
        private double price;

        public int Code
        {
            set { code = value; }
            get { return code; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
    }
    //public int Code{get;set;}
    //public string Name{get;set;}
    //public double Price{get;set;}
}
