using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Marks1
    {
        public static void consume()
        {
            Console.WriteLine("consume");

            Marks m = new Marks();
            m.setMarks("chayank",55,55,55);
            m.calculate();
            m.GetMarks();


            Marks m1 = new Marks();
            m1.setMarks("rav",67, 45, 95);
            m1.calculate();
            m1.GetMarks();

        }
    }

}
