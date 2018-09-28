using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class products1
    {
        public static void consume()
        {
            product p = new product();
            p.setDetails(1, "tv", "sony", "xe5", 89000);
            p.getDetails();
        }
    }
}
