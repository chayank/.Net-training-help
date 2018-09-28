using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }
        public int getlettercount()
        {
            StreamReader sr = new StreamReader("d:/abc.txt");
            System.Threading.Thread.Sleep(6000);
            return sr.ReadToEnd().Length;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Task<int> task = new Task<int>(getlettercount);
            task.Start();
            int count = await task;
            lb1.Content = "no of letters:" + count;
            
        }
    }
}
