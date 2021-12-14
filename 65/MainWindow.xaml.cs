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

namespace _65
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void vypocitejButton_Click(object sender, RoutedEventArgs e)
        {
            string operace = operaceComboBox.Text;
            double cislo1 = double.Parse(cislo1TextBox.Text);
            double vysledek = 0;
            double vysledek1 = 0;
            double vysledek2 = cislo1 * cislo1;
            if (operace == "mm")
            { 
                vysledek = cislo1 * 6.28;
                vysledek1 = vysledek2 * 3.14;
                vysledekTextBlock.Text = $"{vysledek} mm".ToString();
                vysledekTextBlock2.Text = $"{vysledek1} mm²".ToString();
            }
            else if (operace == "cm")
            { 
                vysledek = cislo1 * 6.28;
                vysledek1 = vysledek2 * 3.14;
                vysledekTextBlock.Text = $"{vysledek} cm".ToString();
                vysledekTextBlock2.Text = $"{vysledek1} cm²".ToString();
            }
            else if (operace == "dm")
            { 
                vysledek = cislo1 * 6.28;
                vysledek1 = vysledek2 * 3.14;
                vysledekTextBlock.Text = $"{vysledek} dm".ToString();
                vysledekTextBlock2.Text = $"{vysledek1} dm²".ToString();
            }
            else if (operace == "m")
            {
                vysledek = cislo1 * 6.28;
                vysledek1 =vysledek2 * 3.14;
                vysledekTextBlock.Text = $"{vysledek} m".ToString();
                vysledekTextBlock2.Text = $"{vysledek1} m²".ToString();
            }
            else
            {
                MessageBox.Show("Neplatné číslo");
            }

        }
    }
}
