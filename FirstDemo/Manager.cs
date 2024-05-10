using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class Manager : Employee
    {
        // base keyword will call the base class constructor
        private double food;
        public Manager() : base()
        {

        }
        public Manager(int id, string name, double b, double h, double p, double food)
            : base(id, name, b, h, p)
        {
            this.food = food;
        }

        // calculate salary for manager

        public override void CalculateSalary()
        {
            gross = (bs + hra + food) - pf;
        }

        public override string Display()
        {
            return $"Manager salary empid={eid}, empname={ename},gross={gross}";
        }
    }

}
