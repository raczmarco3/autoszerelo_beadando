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

        public bool ValidateLicensePlate(string licensePlate)
        {
            if (!string.IsNullOrEmpty(LicensePlate.Text))
            {
                licensePlate = LicensePlate.Text;
            }

            Regex regex = new Regex("[A-Z]{3}-{1}[0-9]{3}$");
            if (!regex.IsMatch(licensePlate))
            {
                MessageBox.Show("Hibás rendszám formátum! Helyes formátum: ABC-123", "Figyelmeztetés");
                return false;
            }
            return true;
        }

        public bool ValidateClientName(string clientName)
        {
            if (!string.IsNullOrEmpty(ClientName.Text))
            {
                clientName = ClientName.Text;
            }

            if (string.IsNullOrEmpty(clientName))
            {
                return false;
            }
            return true;
        }

        public bool ValidateCarType(string carType)
        {
            if (!string.IsNullOrEmpty(CarType.Text))
            {
                carType = CarType.Text;
            }

            if (string.IsNullOrEmpty(carType))
            {
                return false;
            }
            return true;
        }

        private bool ValidateTextBox()
        {
            if (ClientName.Text != null)
            {
                if (ValidateClientName(ClientName.Text) == false)
                {
                    MessageBox.Show("Az ügyfél neve nem lehet üres!", "Figyelmeztetés");
                    return false;
                }
            }
            
            if (CarType.Text != null)
            {
                if (ValidateCarType(CarType.Text) == false)
                {
                    MessageBox.Show("Az autó típusa nem lehet üres!", "Figyelmeztetés");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(LicensePlate.Text))
            {
                MessageBox.Show("A rendszám nem lehet üres!", "Figyelmeztetés");
                return false;
            }
            else if (string.IsNullOrEmpty(Problem.Text))
            {
                MessageBox.Show("Az autó probémája nem lehet üres!", "Figyelmeztetés");
                return false;
            }
            else if (LicensePlate.Text != null)
            {
                if (ValidateLicensePlate(LicensePlate.Text) == false)
                {
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
                _work.State = "Felvett";

                WorkDataProvider.CreateWork(_work);

                DialogResult = true;
                Close();
            }
        }
                
    }
}
