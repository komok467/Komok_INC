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

namespace Komok_inc.Views.Pages.ClothesPages
{
    /// <summary>
    /// Логика взаимодействия для clothesPageView.xaml
    /// </summary>
    public partial class clothesPageView : Page
    {
        public clothesPageView()
        {
            InitializeComponent();
        }
        // Алгоритм для реализации нечеткого поиска
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        // Алгоритм применения фильтра по Критериям:
        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {

        }
        // Переходим в страницу создания новой записи
        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new clothesCreatePage());
        }
        // Передаем выбранные данные в страницу редактирования для внесения изменений
        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {

        }
        // Удаления выбранной записи
        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
