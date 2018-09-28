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

namespace WpfApp1
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public string posting { get; set; }
        public static List<Employee> employees = new List<Employee>
                {new Employee{id=1,name="chayank",salary=2000 ,posting="trainer"},
                new Employee{id=2,name="prajjwal",salary=2000 ,posting="devop"},
                 new Employee{id=3,name="arihant",salary=2000 ,posting="tester"},

        };


    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = new Employee();

            int id=Convert.ToInt32(text1.Text);

            foreach(Employee x in Employee.employees)
            {
                if (x.id == id)
                {
                    t1.Content=x.name;
                    t2.Content = x.salary;
                    t3.Content = x.posting;
                }
            }
        }
    }
}
