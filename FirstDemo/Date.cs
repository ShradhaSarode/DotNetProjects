using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstDemo
{
    public class Date
    {
        private int day, month, year;

        public Date()
        {
            day = 15;
            month = 09;
            year = 1996;
        }

        public Date(int d,int m,int y)
        {
            day = d;
            month = m;
            year = y;
        }
        /*
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        */

        public string Display()
        {
            return $"Date: {day}/{month}/{year} ";
        }
    }
}
