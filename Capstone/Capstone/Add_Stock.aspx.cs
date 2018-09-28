using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capstone.Model;

namespace Capstone
{
    public partial class Add_Stock : System.Web.UI.Page
    {
        public static char status = 'A';
        private void InsertStockInfo(int stk_id,string stk_name, int stk_price, int stk_qty, int stk_addedBy, char stk_status)
        {
            StockManager stk_Mgr = new StockManager();
            stk_Mgr.AddStocks(stk_id,stk_name, stk_price, stk_qty, stk_addedBy, stk_status);


        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
          
            InsertStockInfo(6,tbstk_name.Text, Convert.ToInt32(tbstk_price.Text), Convert.ToInt32(tbstk_qty.Text), 1,status);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlstk_status.SelectedValue.Equals("InActive"))
            {
                status = 'I';
            }
        }
    }
}