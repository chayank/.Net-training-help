using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        DataSet ds = new DataSet();
        SqlConnection cn;
        public static int i;
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cs = "server=USER-PC;user id=sa;pwd=1234;database=StpDB";
            cn = new SqlConnection(cs);

            cn.Open();

            MessageBox.Show("Connection Established");

            string query = "select * from tblUsers";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            da.Fill(ds);
            MessageBox.Show("data copied to dataset");
            da.Dispose();
            if (cn.State == ConnectionState.Open)
                cn.Close();

            if (cn.State == ConnectionState.Closed)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                text1.Text = dr[0].ToString();
                t1.Content = dr[1].ToString();
                t2.Content = dr[3].ToString();

            }

        }
    }
}
