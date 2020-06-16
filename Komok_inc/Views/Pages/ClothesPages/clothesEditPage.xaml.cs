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
    /// Логика взаимодействия для clothesEditPage.xaml
    /// </summary>
    public partial class clothesEditPage : Page
    {
        private ClothesData selectItem;
        public clothesEditPage()
        {
            InitializeComponent();
        }

        public clothesEditPage(ClothesData selectItem)
        {
            InitializeComponent();
            this.selectItem = selectItem;
            txtTitle.Text = selectItem.Title;
            txtSize.Text = selectItem.Size.ToString();
            txtStructured.Text = selectItem.Structure;
            comboBoxStyle.Text = selectItem.Style;
            comboBoxCountry.Text = selectItem.Country;
            comboBoxBrend.Text = selectItem.Brend;
            txtPrice.Text = selectItem.Price.ToString();
            dateOfDelivery.SelectedDate = (DateTime)selectItem.Date;
            comboBoxGender.Text = selectItem.Gender;
            comboBoxCategory.Text = selectItem.Category;
            comboBoxProviderTitle.Text = selectItem.ProviderTitle;
            if(selectItem.Photo != null)
            {
                BitmapImage bitmap = new BitmapImage();
                using(MemoryStream stream = new MemoryStream(selectItem.Photo))
                {
                    bitmap.BeginInit();
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.StreamSource = stream;
                    bitmap.EndInit();
                }
                photos.Source = bitmap;
            }
        }

        private void buttonDone_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClothesData editClothes = XApp.db.ClothesData.FirstOrDefault(item => item.ID == selectItem.ID);
                editClothes.Size = int.Parse(txtSize.Text);
                editClothes.Title = txtTitle.Text;
                editClothes.Structure = txtStructured.Text;
                editClothes.Style = comboBoxStyle.Text;
                editClothes.Country = comboBoxCountry.Text;
                editClothes.Brend = comboBoxBrend.Text;
                editClothes.Price = Convert.ToDouble(txtPrice.Text);
                editClothes.Date = (DateTime)dateOfDelivery.SelectedDate;
                editClothes.Category = comboBoxCategory.Text;
                editClothes.Gender = comboBoxGender.Text;
                editClothes.ProviderTitle = comboBoxProviderTitle.Text;
                // Разбиваем изображение на массив байтов
                MemoryStream stream = new MemoryStream();
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapImage)photos.Source));
                encoder.Save(stream);
                editClothes.Photo = stream.ToArray();
                XApp.db.SaveChanges();
                MessageBox.Show("Данные успешно сохранены", "Итог опреции добавления.", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        // Загрузка изображения
        private void buttonLoadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileExplorer = new OpenFileDialog();
            fileExplorer.Filter = "Image (*.png; *.jpg; *.jpeg;)|*.png; *.jpg; *.jpeg";
            if(fileExplorer.ShowDialog() == true)
            {
                BitmapImage bitmap = new BitmapImage(new Uri(fileExplorer.FileName));
                photos.Source = bitmap;
            }
        }
        // Загрузка данных
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            loadDataInCombo loadDataInCombo = new loadDataInCombo();
            loadDataInCombo.loadDataCategory(comboBoxCategory);
            loadDataInCombo.loadDataGender(comboBoxGender);
        }
    }
}
