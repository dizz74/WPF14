
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();

            products = new ObservableCollection<Product>();
            products.Add(new Product("Пирожок", 100, "Img/pie.png", ECategory.FOOD));
            products.Add(new Product("Кофе машина", 4410, "Img/coffee-machine.png", ECategory.ELECTRONIC));
            products.Add(new Product("Апельсин", 80, "Img/orange.png", ECategory.FOOD));
            products.Add(new Product("Миксер", 1430, "Img/mixer.png", ECategory.ELECTRONIC));
            products.Add(new Product("Рябина", 150, "Img/rowan.png", ECategory.FOOD));
            products.Add(new Product("Духовка", 3850, "Img/oven.png", ECategory.ELECTRONIC));

            listbox.ItemsSource = products;
        }
    }
}
