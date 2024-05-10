using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class Student
    {
        private int rollno;
        private string sname;
        private int fees;

        public Student()
        {
            rollno = 1;
            sname = "Lotus";
            fees = 5000;
        }

        public Student(int r,string name)
        {
            rollno = r;
            sname = name;
        }

        public Student(int rollno,string sname,int fees)
        {
            this.rollno = rollno;
            this.sname = sname;
            this.fees = fees;
        }

        public string Display()
        {
            return $"Roll no: {rollno}, name: {sname}, fees: {fees}";
        }
    }
}
