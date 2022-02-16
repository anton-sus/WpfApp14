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

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Products> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Products>();
            products.Add(new Products()
            {
                Name = "Яблоки",
                Price = 90,
                ProductType = PruductTypes.Фрукты,
                ImagePath = "/Data/fruits.png",
            });
            products.Add(new Products()
            {
                Name = "Вишня",
                Price = 190,
                ProductType = PruductTypes.Фрукты,
                ImagePath = "/Data/fruits.png",
            });
            products.Add(new Products()
            {
                Name = "Тыква",
                Price = 120,
                ProductType = PruductTypes.Овощи,
                ImagePath = "/Data/vegs.png",
            });
            products.Add(new Products()
            {
                Name = "Морковь",
                Price = 70,
                ProductType = PruductTypes.Овощи,
                ImagePath = "/Data/vegs.png",
            });
            products.Add(new Products()
            {
                Name = "Томаты",
                Price = 100,
                ProductType = PruductTypes.Овощи,
                ImagePath = "/Data/vegs.png",
            });
            listBox.ItemsSource = products;
        }
    }
}
