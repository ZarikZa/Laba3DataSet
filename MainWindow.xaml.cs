using Laba3DataSet.Laba1DataSetTableAdapters;
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

namespace Laba3DataSet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OrdersTableAdapter OrdersTableAdapter = new OrdersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            datygridy.ItemsSource = OrdersTableAdapter.GetDataBy();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            datygridy.Columns[0].Visibility = Visibility.Collapsed;
            datygridy.Columns[1].Visibility = Visibility.Collapsed;
        }
    }
}
