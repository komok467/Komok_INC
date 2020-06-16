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
    /// Логика взаимодействия для createProviderPage.xaml
    /// </summary>
    public partial class createProviderPage : Page
    {
        public createProviderPage()
        {
            InitializeComponent();
        }
        // Переход назад
        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void buttonDone_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Provider provider = new Provider();
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
                XApp.db.Provider.Add(provider);
                XApp.db.SaveChanges();
                MessageBox.Show("Добавление прошло успешно!", "Итог оперции.", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
}
        // Загрузка фотографии
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
