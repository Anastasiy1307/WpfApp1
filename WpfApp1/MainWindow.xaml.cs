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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Reg(object sender, RoutedEventArgs e)
        {
            Registr registr = new Registr();
            registr.Show();
        }

        private void Add11(object sender, RoutedEventArgs e)
        {
            Add add1 = new Add();
            add1.Show();
        }

        private void Logo1(object sender, RoutedEventArgs e)
        {
            LOGO logo = new LOGO();
            logo.Show();
        }
    }
}
