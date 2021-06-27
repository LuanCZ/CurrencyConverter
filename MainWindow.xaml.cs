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

namespace CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double dMontantMonnaie1;
        double dMontantMonnaie2;
        string sMonnaie1;
        string sMonnaie2;
        CurrencyConvert Currency;
        public MainWindow()
        {
            dMontantMonnaie1 = double.Parse(txtMonnaie1.Text);
            dMontantMonnaie2 = double.Parse(txtMonnaie2.Text);
            sMonnaie1 = cmboxMonnaie1.Text;
            sMonnaie2 = cmboxMonnaie2.Text;

            Currency = new CurrencyConvert(dMontantMonnaie1, dMontantMonnaie2, sMonnaie1, sMonnaie2);

            InitializeComponent();
            Currency.RemplirCombobox(cmboxMonnaie1);
            Currency.RemplirCombobox(cmboxMonnaie2);



        }
    }
}
