using Komok_inc.Context;
using Komok_inc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Komok_inc.Moderator
{
    public class loadDataInCombo
    {
        public void loadDataCategory(ComboBox comboBox)
        {
            try
            {
                var query = XApp.db.Category.Select(item => new
                {
                    category = item.Category1
                });
                var collection = from item in query select item.category;
                comboBox.ItemsSource = collection.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public void loadDataGender(ComboBox comboBox)
        {
            try
            {
                var query = XApp.db.Gender.Select(item => new
                {
                     gender = item.Gender1
                });
                var collection = from item in query select item.gender;
                comboBox.ItemsSource = collection.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
