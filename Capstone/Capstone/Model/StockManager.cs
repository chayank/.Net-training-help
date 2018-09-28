using System.Data.Entity.Validation;

namespace Capstone.Model
{
    public class StockManager
    {

        private DB.StpDBEntities1 sde = new DB.StpDBEntities1();
         
        public void AddStocks(int stk_id,string stk_name,int stk_price,int stk_qty, int stk_addedBy,char stk_status)
        {

           
            try
            {
                DB.Stock stk = new DB.Stock();
                //stk.stockId = stk_id;
                stk.stockName = stk_name;
                stk.quantity = stk_qty;
                stk.quantity_remaining = stk_qty;
                stk.addedBy = stk_addedBy;
                stk.status = stk_status.ToString();

                sde.Stocks.Add(stk);
                sde.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }




        }
    }
}