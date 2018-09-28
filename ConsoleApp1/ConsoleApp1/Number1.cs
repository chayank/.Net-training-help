using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Number1
    {
        public static void Consume()
        {
            Number n1 = new Number();
            n1.setNumber(100);
            n1.getNumber();

            Numbers n2 = new Numbers();
            n2.setNumbers(100, 100);
            n2.getNumbers();

        }
    }
}
