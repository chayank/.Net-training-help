using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Number
    {
        private int n;

        public void setNumber(int n)
        {
            this.n = n;

        }

        public void getNumber()
        {
            Console.WriteLine(this.n);
        }
    }
}
