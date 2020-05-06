using AutoSzerelo_Munka_Felvevo_Kliens.DataProviders;
using AutoSzerelo_Munka_Felvevo_Kliens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AutoSzerelo_Munka_Felvevo_Kliens
{
    /// <summary>
    /// Interaction logic for ModifyWindow.xaml
    /// </summary>
    public partial class ModifyWindow : Window
    {
        private readonly Work _work;
        public ModifyWindow(Work work)
        {
            InitializeComponent();

            if(work != null)
            {
                _work = work;
                ClientName.Text = _work.ClientName;
                CarType.Text = _work.CarType;
                LicensePlate.Text = _work.LicensePlate;
                Problem.Text = _work.Problem;
            }
            else
            {
                MessageBox.Show("A work üres!", "Hiba");
            }
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
                MessageBox.Show("Az autó probémája nem lehet üres!", "Figyelmeztetés");
                return false;
            }
            else if (LicensePlate.Text != null)
            {
                Regex regex = new Regex("[A-Z]{3}-{1}[0-9]{3}$");
                if (!regex.IsMatch(LicensePlate.Text))
                {
                    MessageBox.Show("Hibás rendszám formátum! Helyes formátum: ABC-123", "Figyelmeztetés");
                    return false;
                }
            }
            return true;
        }

        private void ModifyClick(object sender, RoutedEventArgs e)
        {          
            if (ValidateTextBox())
            {                
                _work.ClientName = ClientName.Text;
                _work.CarType = CarType.Text;
                _work.LicensePlate = LicensePlate.Text;
                _work.Problem = Problem.Text;

                WorkDataProvider.UpdateWork(_work);
                DialogResult = true;
                Close();
            }            
        }
    }
}
