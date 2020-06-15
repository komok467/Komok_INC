using Komok_inc.Views.Pages.ClothesPages;
using Komok_inc.Views.Pages.ProviderPages;
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

namespace Komok_inc.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для startPage.xaml
    /// </summary>
    public partial class startPage : Page
    {
        public startPage()
        {
            InitializeComponent();
        }
        // переход на страницу "Вид одежды"
        private void buttonClothesView_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new clothesPageView());
        }
        // переход на страницу "Вид поставщиков"
        private void buttonProiderView_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProviderViewPage());
        }
    }
}
