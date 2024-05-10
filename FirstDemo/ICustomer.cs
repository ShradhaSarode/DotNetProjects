using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal interface ICustomer
    {

        string Print();
    }

    public interface IOrder
    {
        string Print();
    }

    public class Trasaction : ICustomer, IOrder
    {
        // it is by default public
        string ICustomer.Print()
        {
            return "Customer details";
        }

        string IOrder.Print()
        {
            return "Order details";
        }
    }

}
