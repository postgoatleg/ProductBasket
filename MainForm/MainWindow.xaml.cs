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
using ProductsClass;

namespace MainForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] oprnds = { "+", "-", "*", "++", "/", ">", "<", ">=", "<="};
            dataGrid.ItemsSource = products;
            mathOprndComboBox.ItemsSource = oprnds;
            numberTextBox.Visibility = Visibility.Hidden;
            resultLabel.Visibility = Visibility.Hidden;
        }

        private List<Product> products = new List<Product>
        {
            new Product("Prod 1", 100),
            new Product("Prod 2", 53),
            new Product("Prod 3", 72)
        };



        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product(nameTextBox.Text, Convert.ToDouble(priceTextBox.Text)));
            dataGrid.Items.Refresh();
            RefreshComboBox(prod1ComboBox);
            RefreshComboBox(prod2ComboBox);
        }

        private void RefreshComboBox(ComboBox box)
        {
            box.Items.Clear();
            foreach(Product product in products)
            {
                box.Items.Add(product.Name);
            }
        }

        private void mathOprndComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int choosed = mathOprndComboBox.SelectedIndex;
            if (choosed == 3)
            {
                prod2ComboBox.IsEnabled = false;
                prod2ComboBox.SelectedIndex = -1;
            }
            else if (choosed == 2 || choosed == 4)
            {
                numberTextBox.Visibility = Visibility.Visible;
            }
            else prod2ComboBox.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int i1 = prod1ComboBox.SelectedIndex, i2 = prod2ComboBox.SelectedIndex;
            switch (mathOprndComboBox.SelectedIndex)
            {
                case -1:
                    break;
                case 0:
                    products.Add(products[i1] + products[i2]);
                    break;
                case 1:
                    products.Add(products[i1] - products[i2]);
                    break;
                case 2:
                    products.Add(products[i1] * Convert.ToDouble(numberTextBox));
                    break;
                case 3:
                    products.Add(products[i1]++);
                    break;
                case 4:
                    products.Add(products[i1] / Convert.ToDouble(numberTextBox));
                    break;
                case 5:
                    resultLabel.Visibility = Visibility.Visible;
                    resultLabel.Content = $"{products[i1]>products[i2]}";
                    break;
                case 6:
                    resultLabel.Visibility = Visibility.Visible;
                    resultLabel.Content = $"{products[i1] < products[i2]}";
                    break;
                case 7:
                    resultLabel.Visibility = Visibility.Visible;
                    resultLabel.Content = $"{products[i1] >= products[i2]}";
                    break;
                case 8:
                    resultLabel.Visibility = Visibility.Visible;
                    resultLabel.Content = $"{products[i1] <= products[i2]}";
                    break;
            }
            dataGrid.Items.Refresh();
        }
    }
}
