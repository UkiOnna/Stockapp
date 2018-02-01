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

namespace StockApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> items;
        public MainWindow(List<string> item)
        {
            InitializeComponent();
            items = new List<string>();
            foreach (string i in item)
            {
                ListItems.Items.Add(i);
            }

        }
        public MainWindow()
        {
            InitializeComponent();
            items = new List<string>();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < ListItems.Items.Count; i++)
            {
                items.Add((string)ListItems.Items[i]);
            }
            if (items.Count != 0)
            {
                new AddItem(items).Show();
            }
            else
            {
                new AddItem().Show();
            }

            mainWin.Close();
        }
    }
}
