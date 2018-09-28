using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBrowserApp1
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            int id=Convert.ToInt32(t1.Text);
            string name = t2.Text;
            int qty = Convert.ToInt32(t3.Text);
            int rem_qt = Convert.ToInt32(t3.Text);
            string status = t4.Text;
            StpDBEntities db = new StpDBEntities();
            tblStock stk = new tblStock();
            stk.stockId = id;
            stk.stockName = name;
            stk.quantity = qty;
            stk.quantity_remaining = rem_qt;
            stk.addedBy = 1;
            stk.status = status;

            db.tblStocks.Add(stk);
            db.SaveChanges();

        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(t1.Text);
           
            StpDBEntities db = new StpDBEntities();

           

            foreach(tblStock s in db.tblStocks)
            {
                if(s.stockId==id)
                {
                    db.tblStocks.Remove(s);
                }
            }

            db.SaveChanges();


        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(t1.Text);
            string name = t2.Text;
            int qty = Convert.ToInt32(t3.Text);
            int rem_qt = Convert.ToInt32(t3.Text);
            string status = t4.Text;
            StpDBEntities db = new StpDBEntities();
            tblStock stk = new tblStock();
            

            foreach (tblStock s in db.tblStocks)
            {
                if (s.stockId == id)
                {
                    stk = s;
                }
            }

            
            stk.stockName = name;
            stk.quantity = qty;
            stk.quantity_remaining = rem_qt;
            stk.addedBy = 1;
            stk.status = status;

            db.SaveChanges();
        }
    }
}
