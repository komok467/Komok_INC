using Komok_inc.Context;
using Komok_inc.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для editProviderPage.xaml
    /// </summary>
    public partial class editProviderPage : Page
    {
        private Provider selectedItem;
        public editProviderPage()
        {
            InitializeComponent();
        }

        public editProviderPage(Provider selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;
            txtTitle.Text = selectedItem.Title;
            comboBoxCountry.Text = selectedItem.Country;
            txtCity.Text = selectedItem.City;
            txtEmail.Text = selectedItem.Email;
            if (selectedItem.Logo != null)
            {
                BitmapImage bitmap = new BitmapImage();
                using (MemoryStream stream = new MemoryStream(selectedItem.Logo))
                {
                    bitmap.BeginInit();
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.StreamSource = stream;
                    bitmap.EndInit();
                }
                logoImage.Source = bitmap;
            }
        }
        // Назад
        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        // Изменение записи
        private void buttonDone_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Provider provider = XApp.db.Provider.FirstOrDefault(item => item.ID == selectedItem.ID);
                provider.Title = txtTitle.Text;
                provider.Country = comboBoxCountry.Text;
                provider.City = txtCity.Text;
                // Разбиваем изображение на массив байтов
                MemoryStream stream = new MemoryStream();
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapImage)logoImage.Source));
                encoder.Save(stream);
                provider.Logo = stream.ToArray();
                provider.Email = txtEmail.Text;
                XApp.db.SaveChanges();
                MessageBox.Show("Редактирование прошло успешно!", "Итог оперции.", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        // Загрузка изображения
        private void buttonLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog fileExplorer = new OpenFileDialog();
                fileExplorer.Filter = "Image (*.png; *.jpg; *.jpeg;)|*.png; *.jpg; *.jpeg";
                if (fileExplorer.ShowDialog() == true)
                {
                    BitmapImage bitmap = new BitmapImage(new Uri(fileExplorer.FileName));
                    logoImage.Source = bitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
