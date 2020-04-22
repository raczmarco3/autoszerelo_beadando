using AutoSzerelo_Munka_Felvevo_Kliens.DataProviders;
using AutoSzerelo_Munka_Felvevo_Kliens.Models;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace AutoSzerelo_Munka_Felvevo_Kliens
{
    /// <summary>
    /// Interaction logic for AddNewWindow.xaml
    /// </summary>
    public partial class AddNewWindow : Window
    {
        public AddNewWindow()
        {
            InitializeComponent();            
        }

        private bool ValidateTextBox()
        {
            if (string.IsNullOrEmpty(ClientName.Text))
            {
                MessageBox.Show("Az ügyfél neve nem lehet üres!", "Figyelmeztetés");
                return false;
            }
            else if (string.IsNullOrEmpty(CarType.Text))
            {
                MessageBox.Show("Az autó típusa nem lehet üres!", "Figyelmeztetés");
                return false;
            }
            else if (string.IsNullOrEmpty(LicensePlate.Text))
            {
                MessageBox.Show("A rendszám nem lehet üres!", "Figyelmeztetés");
                return false;
            }
            else if (string.IsNullOrEmpty(Problem.Text))
            {
                MessageBox.Show("Az autó baja nem lehet üres!", "Figyelmeztetés");
                return false;
            }else if(LicensePlate.Text != null)
            {
                Regex regex = new Regex("[A-Z]{3}-{1}[0-9]{3}");
                if (!regex.IsMatch(LicensePlate.Text))
                {
                    MessageBox.Show("Hibás rendszám formátum! Helyes formátum: ABC-123", "Figyelmeztetés");
                    return false;
                }
            }

            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateTextBox())
            {
                var _work = new Work();
                _work.ClientName = ClientName.Text;
                _work.CarType = CarType.Text;
                _work.LicensePlate = LicensePlate.Text;
                _work.Problem = Problem.Text;

                WorkDataProvider.CreateWork(_work);

                DialogResult = true;
                Close();
            }
        }

        //Ellenőrizzük,hogy a beírt név csak betűket tartalmaz-e
        private void NameValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+[aáeéiíoóöőuúüű]+[AÁEÉIÍOÓÖŐUÚÜŰ]");
            e.Handled = regex.IsMatch(e.Text);
        }
        
    }
}
