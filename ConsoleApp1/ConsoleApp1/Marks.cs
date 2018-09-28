using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Marks
    {
        private string name;
        private int p, c, m,total;
        private float avg, per;

        public void setMarks(string name,int p,int c,int m)
        {
            Console.WriteLine("hello");
            this.name = name;
            this.p = p;
            this.c = c;
            this.m = m;

        }

        public void calculate()
        {
            total = p + c + m;
            avg = total / 3;
            per = (total / 300) * 100;
        }

        public void GetMarks()
        {
            Console.WriteLine(name);
            Console.WriteLine("total marks {0}",total);
            Console.WriteLine("total average {0}", avg);
            Console.WriteLine("total perc {0}", per);
        }
    }
}
