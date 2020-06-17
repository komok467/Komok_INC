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
            clothesDataView.ItemsSource = XApp.db.ClothesData.Where(item => item.Title.Contains(txtSearch.Text) ||
            item.Structure.Contains(txtSearch.Text) || 
            item.Price.ToString().Contains(txtSearch.Text) || 
            item.Size.ToString().Contains(txtSearch.Text) || 
            item.Country.Contains(txtSearch.Text) || 
            item.Brend.Contains(txtSearch.Text) ||
            item.Gender.Contains(txtSearch.Text) ||
            item.ProviderTitle.Contains(txtSearch.Text) || 
            item.Style.Contains(txtSearch.Text)).ToList();
        }
        // Алгоритм применения фильтра по Критериям:
        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            clothesDataView.ItemsSource = XApp.db.ClothesData.Where(item => item.Date == searchInDate.SelectedDate).ToList();
        }
        // Переходим в страницу создания новой записи
        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new clothesCreatePage());
        }
        // Передаем выбранные данные в страницу редактирования для внесения изменений
        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClothesData editClothes = (ClothesData)clothesDataView.SelectedItem;
                if (editClothes != null)
                    NavigationService.Navigate(new clothesEditPage(editClothes));
                else
                    throw new Exception("Пожалуйста, выберите запись, которую хотите отредактировать!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        // Удаления выбранной записи
        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClothesData selectedItem = (ClothesData)clothesDataView.SelectedItem;
                if (MessageBox.Show("Вы действительно хотите удалить выбранную вами запись? Данные будут удалены без возможности восстановления!", "Внимание!",
                       MessageBoxButton.YesNo,
                       MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    ClothesData removeClothes = XApp.db.ClothesData.FirstOrDefault(item => item.ID == selectedItem.ID);
                    XApp.db.ClothesData.Remove(removeClothes);
                    XApp.db.SaveChanges();
                    Page_Loaded(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        // Выгрузка данных при загрузке страницы
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            clothesDataView.ItemsSource = XApp.db.ClothesData.ToList();
        }
        Export export = new Export();
        // Экспортировать в TXT
        private void buttonExport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                export.ExportToTxt(clothesDataView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        // Назад к истокам
        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
