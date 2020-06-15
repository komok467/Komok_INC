using Komok_inc.Context;
using Komok_inc.Models;
using Komok_inc.Moderator;
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

namespace Komok_inc.Views.Pages.ClothesPages
{
    /// <summary>
    /// Логика взаимодействия для clothesCreatePage.xaml
    /// </summary>
    public partial class clothesCreatePage : Page
    {
        public clothesCreatePage()
        {
            InitializeComponent();
        }
        // Загрузка изображения из проводника
        private void buttonLoadImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog fileExplorer = new OpenFileDialog();
                fileExplorer.Filter = "IMAGE (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
                if(fileExplorer.ShowDialog() == true)
                {
                    BitmapImage image = new BitmapImage(new Uri(fileExplorer.FileName));
                    photos.Source = image;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        // Фиксация данные в Базе Данных
        private void buttonDone_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClothesData newClothes = new ClothesData();
                newClothes.Title = txtTitle.Text;
                newClothes.Size = int.Parse(txtSize.Text);
                newClothes.Structure = txtStructured.Text;
                newClothes.Style = comboBoxStyle.Text;
                newClothes.Country = comboBoxCountry.Text;
                newClothes.Brend = comboBoxBrend.Text;
                newClothes.Price = Convert.ToDouble(txtPrice.Text);
                newClothes.Date = (DateTime)dateOfDelivery.SelectedDate;
                newClothes.Category = comboBoxCategory.Text;
                newClothes.Gender = comboBoxGender.Text;
                newClothes.ProviderTitle = comboBoxProviderTitle.Text;
                // Разбиваем изображение на массив байтов
                MemoryStream stream = new MemoryStream();
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapImage)photos.Source));
                encoder.Save(stream);
                newClothes.Photo = stream.ToArray();
                XApp.db.ClothesData.Add(newClothes);
                XApp.db.SaveChanges();
                MessageBox.Show("Данные успешно сохранены", "Итог опреции добавления.", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        // Загрузка страницы
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            loadDataInCombo loadDataInCombo = new loadDataInCombo();
            loadDataInCombo.loadDataCategory(comboBoxCategory);
            loadDataInCombo.loadDataGender(comboBoxGender);
        }
    }
}
