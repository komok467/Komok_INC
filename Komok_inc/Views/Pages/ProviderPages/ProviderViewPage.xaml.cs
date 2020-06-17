using Komok_inc.Context;
using Komok_inc.Models;
using Komok_inc.Moderator;
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

namespace Komok_inc.Views.Pages.ProviderPages
{
    /// <summary>
    /// Логика взаимодействия для ProviderViewPage.xaml
    /// </summary>
    public partial class ProviderViewPage : Page
    {
        public ProviderViewPage()
        {
            InitializeComponent();
        }
        // Создать новую запись
        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new createProviderPage());
        }
        // Изменить запись
        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Provider editProvider = (Provider)dataProviderView.SelectedItem;
                if (editProvider != null)
                    NavigationService.Navigate(new editProviderPage(editProvider));
                else
                    throw new Exception("Пожалуйста, выберите запись, которую хотите отредактировать!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        // Удалить запись
        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Provider selectedItem = (Provider)dataProviderView.SelectedItem;
                if (MessageBox.Show("Вы действительно хотите удалить выбранную вами запись? Данные будут удалены без возможности восстановления!", "Внимание!",
                       MessageBoxButton.YesNo,
                       MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Provider removeProvider = XApp.db.Provider.FirstOrDefault(item => item.ID == selectedItem.ID);
                    XApp.db.Provider.Remove(removeProvider);
                    XApp.db.SaveChanges();
                    Page_Loaded(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        // Загрузка данных
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataProviderView.ItemsSource = XApp.db.Provider.ToList();
        }
        // Нечёткий поиск
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataProviderView.ItemsSource = XApp.db.Provider.Where(item => item.Title.Contains(txtSearch.Text) || item.Country.Contains(txtSearch.Text) || item.City.Contains(txtSearch.Text) || item.Email.Contains(txtSearch.Text)).ToList();
        }
        Export export = new Export();
        // Экспортировать в TXT
        private void buttonExport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                export.ExportToTxt(dataProviderView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        // Назад
        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
