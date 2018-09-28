using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Numbers
    {
        private int x, y;
        public void setNumbers(int x,int y)
        {
            this.x = x;
            this.y = y;

        }
        public void getNumbers()
        {
            Console.WriteLine("{0} and  {1} ",this.x,this.y);
        }
    }
}
