using AutoSzerelo_Auto_Szerelo_Kliens.DataProvider;
using AutoSzerelo_Auto_Szerelo_Kliens.Models;
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

namespace AutoSzerelo_Auto_Szerelo_Kliens
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

        private void UpdateWork()
        {
            var _works = DataSortedByDate();
            WorksListBox.ItemsSource = _works;
        }

        //Rendezzük a kapott adatokat időrendi sorrendben (a legújabb van legelöl)
        private IList<Work> DataSortedByDate()
        {
            var originalDatas = WorkDataProvider.GetWork();
            IEnumerable<Work> sortedData = originalDatas.OrderByDescending(x => x.Date);
            IList<Work> sortedList = sortedData.ToList();

            return sortedList;
        }

        private void WorksListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedWork = WorksListBox.SelectedItem as Work;

            if (selectedWork != null)
            {
                if(selectedWork.State == "Felvett")
                {
                    if (MessageBox.Show("Elkezded ezt a munkát?", "Figyelmeztetés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        selectedWork.State = "Elkezdett";
                        WorkDataProvider.UpdateWork(selectedWork);
                        UpdateWork();
                    }
                }else if (selectedWork.State == "Elkezdett")
                {
                    if (MessageBox.Show("Befejezed ezt a munkát?", "Figyelmeztetés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        selectedWork.State = "Befejezett";
                        WorkDataProvider.UpdateWork(selectedWork);
                        UpdateWork();
                    }
                }
            }
            WorksListBox.UnselectAll();
        }
    }
}
