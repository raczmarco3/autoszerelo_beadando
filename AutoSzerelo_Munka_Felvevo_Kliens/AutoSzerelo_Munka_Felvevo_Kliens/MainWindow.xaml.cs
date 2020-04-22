using AutoSzerelo_Munka_Felvevo_Kliens.DataProviders;
using AutoSzerelo_Munka_Felvevo_Kliens.Models;
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

namespace AutoSzerelo_Munka_Felvevo_Kliens
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateWork();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void WorksListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UpdateWork()
        {
           var _works = DataSortedByDate();            
           WorksListBox.ItemsSource = _works;
        }

        //Rendezzük a kapott adatokat időrendi sorrendben (a legújabb van legelöl)
        private IList<Work> DataSortedByDate ()
        {
            var originalDatas = WorkDataProvider.GetWork();
            IEnumerable<Work> sortedData = originalDatas.OrderByDescending(x => x.Date);
            IList<Work> sortedList = sortedData.ToList();

            return sortedList;
        }

        private void RemoveWork(object sender, RoutedEventArgs e)
        {
            var window = new DeleteWindow();
            
            if(window.ShowDialog() ?? false)
            {
                UpdateWork();
            }

        }

        private void AddNewButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddNewWindow();

            if (window.ShowDialog() ?? false)
            {
                UpdateWork();
            }
        }
    }
}
