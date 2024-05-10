using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class Product1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product1(int id, string name, int price)
        {
            Id = id; Name = name;
            Price = price;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Product Details"); Console.WriteLine("Id:" + Id);
            Console.WriteLine("Name:" + Name); Console.WriteLine("Price:" + Price);
        }
    }
    
}
