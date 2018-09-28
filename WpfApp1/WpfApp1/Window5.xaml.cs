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
using System.Windows.Shapes;
using WpfApp1.ServiceReference1;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Service2Client x = new Service2Client();
            tblStock stk=x.getStockRowbyId(Convert.ToInt32(txt1.Text));
            if (stk.stockName == null)
            {
                stat.Content = "No Stock Found for this ID";
                txt2.Text = "";
                txt3.Text = "";
                txt4.Text = "";
            }
            else
            {
                txt2.Text = stk.stockName;
                txt3.Text = stk.quantity.ToString();
                txt4.Text = stk.status;
                stat.Content = "Succes!! found record !!";
            }
            
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Service2Client x = new Service2Client();
            tblStock stk1 = x.getStockRowbyId(Convert.ToInt32(txt1.Text));

            tblStock stk = new tblStock {
                stockId = Convert.ToInt32(txt1.Text),
                stockName =txt2.Text,
                quantity = Convert.ToInt32(txt3.Text),
                quantity_remaining = Convert.ToInt32(txt3.Text) ,
                addedBy=1,
                status=txt4.Text
            };
            if (stk1.stockName == null)
            {
                x.setStock(stk);
                stat.Content = "stock has been added";
            }
            else
            {
                stat.Content = "stockID already exists";

            }
            
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";


        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Service2Client x = new Service2Client();

            
            if (!x.deleteStockById(Convert.ToInt32(txt1.Text)) )
            { stat.Content = "invalid id";
                
            }
            else
            {
                stat.Content = "data deleted";
            }
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";


        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Service2Client x = new Service2Client();
            

            tblStock stk = new tblStock
            {
                stockId = Convert.ToInt32(txt1.Text),
                stockName = txt2.Text,
                quantity = Convert.ToInt32(txt3.Text),
                quantity_remaining = Convert.ToInt32(txt3.Text),
                addedBy = 1,
                status = txt4.Text
            };
            if (!x.updateStockById(stk))
            { stat.Content = "invalid id"; }
            else
            {
                stat.Content = "data updated";
            }

            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }

        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
           
            
        }

        private void txt2_TextChanged(object sender, TextChangedEventArgs e)
        {
            
           
            
        }

        private void txt3_TextChanged(object sender, TextChangedEventArgs e)
        {
           
           
           
        }

        private void txt4_TextChanged(object sender, TextChangedEventArgs e)
        {
           
          
            
        }
    }
}
