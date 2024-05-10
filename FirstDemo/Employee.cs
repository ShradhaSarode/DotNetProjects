using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class Employee
    {
        // decalare the data members
        protected int eid;   // 4 bytes
        protected string ename; // 4 bytes
        protected double bs, hra, pf, gross; // 32 bytes


        public Employee()
        {
            eid = 1;
            ename = "Ritu";
            bs = 4000;
            hra = 2000;
            pf = 1000;
        }

        public  Employee(int id,string name,double b,double hr,double  p)
        {
            eid = id;
            ename = name;
            bs = b;
            hra = hr;
            pf = p;
        }

        public virtual void CalculateSalary()
        {
            gross = (bs + hra) - pf;
        }

        public virtual string Display()
        {
            return $"Employee id: {eid}, name: {ename}, gross: {gross} ";
        }
    }
}
