using AutoSzerelo_Munka_Felvevo_Kliens.DataProviders;
using System.Windows;
using System.Windows.Input;
using System.Text.RegularExpressions;

namespace AutoSzerelo_Munka_Felvevo_Kliens
{
    /// <summary>
    /// Interaction logic for DeleteWindow.xaml
    /// </summary>
    public partial class DeleteWindow : Window
    {
        public DeleteWindow()
        {
            InitializeComponent();
        }

        //Csak számokat engedünk beírni, mivel az id csak szám lehet
        private void NumberValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void DeleteWork(object sender, RoutedEventArgs e)
        {
            if (ValidateTextBox())
            {
                if (MessageBox.Show("Tényleg törölni akarod ezt a munkát?", "Figyelmeztetés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    var torlendoId = long.Parse(TorlendoId.Text);
                    WorkDataProvider.DeleteWork(torlendoId);
                }

                DialogResult = true;
                Close();
            }            
        }

        private bool ValidateTextBox()
        {
            if (string.IsNullOrEmpty(TorlendoId.Text))
            {
                MessageBox.Show("Az ID nem lehet üres!", "Hiba");
                return false;
            }

            return true;
        }
    }
}
