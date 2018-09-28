using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trainingcheck.Models
{
    public class UserManager : StockManager
    {

       
        public tblUser tblUser { get; set; }
        public tblWallet tblWallet { get; set; }
        public tblHolding tblHolding { get; set; }
        public tblTradeRequest tblTradeRequest { get; set; }
        public tblTransaction tblTransactions { get; set; }
        public IEnumerable<tblHolding> tblHoldings { get; set; }

        public UserManager()
        {
            StpDBEntities = new StpDBEntities();

        }

    }
}