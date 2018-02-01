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

namespace StockApp
{
    /// <summary>
    /// Логика взаимодействия для AddItem.xaml
    /// </summary>
    public partial class AddItem : Window
    {

        private Item item;
        private List<string> items;
        public AddItem()
        {
            InitializeComponent();
            items = new List<string>();
            item = new Item();
            BoxItem.Items.Add(TypeItem.Поступление);
            BoxItem.Items.Add(TypeItem.Убытие);
        }

        public AddItem(List<string> it)
        {
            InitializeComponent();
            items = new List<string>();
            foreach (string i in it)
            {
                items.Add(i);
            }
            item = new Item();
            BoxItem.Items.Add(TypeItem.Поступление);
            BoxItem.Items.Add(TypeItem.Убытие);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            int a = 1;
            if (BoxItem.SelectedItem == null || TextItem == null || CountItem == null)
            {
                MessageBox.Show("Вы неправильно заполнили поля");
            }
            else
            {
                item.Type = (TypeItem)BoxItem.SelectedItem;
                item.Name = TextItem.Text;
                item.Count = CountItem.Text;
                items.Add(item.ToString());

                new MainWindow(items).Show();
                AddWin.Close();
            }
        }
    }
}
