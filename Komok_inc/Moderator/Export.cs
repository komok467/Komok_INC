using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Komok_inc.Moderator
{
    class Export
    {
        public void ExportToTxt(DataGrid dataGrid)
        {
            dataGrid.SelectAllCells();
            dataGrid.ClipboardCopyMode = DataGridClipboardCopyMode.ExcludeHeader;
            ApplicationCommands.Copy.Execute(null, dataGrid);
            dataGrid.UnselectAllCells();

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TXT (*.txt)|*.txt";
            save.FileName = "Data.txt";
            bool fileError = false;
            if (save.ShowDialog() == true)
            {
                if (File.Exists(save.FileName))
                {
                    try
                    {
                        File.Delete(save.FileName);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        string path1 = save.FileName;
                        string result1 = (string)Clipboard.GetText(TextDataFormat.Text);
                        Clipboard.Clear();
                        StreamWriter stream = new StreamWriter(path1);
                        stream.WriteLine(result1);
                        stream.Close();
                        MessageBox.Show("Сохранение данных прошла успешно!");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }

        }
    }
}
