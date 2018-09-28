using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class product
    {
        private int id, price;
        private String prodtype, prod, prodmodel;

        public void setDetails(int id,String prodtype,String prod,String prodmodel,int price)
        {
            this.id = id;
            this.prodtype = prodtype;
            this.prod = prod;
            this.prodmodel = prodmodel;

        }
        
        public void getDetails()
        {
            Console.WriteLine("{0} - {1} - {2} - {3}",id,prodtype,prod,prodmodel);
        }

    }
}
