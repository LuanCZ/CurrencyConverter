using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace CurrencyConverter
{
    class CurrencyConvert
    {

        private List<List<string>> sListCurrency;
        private double dMontantMonnaie1;
        private double dMontantMonnaie2;
        private string sMonnaie1;
        private string sMonnaie2;



        public CurrencyConvert(double MontantMonnaie1, double MontantMonnaie2, string Monnaie1, string Monnaie2)
        {
            dMontantMonnaie1 = MontantMonnaie1;
            dMontantMonnaie2 = MontantMonnaie2;
            sMonnaie1 = Monnaie1;
            sMonnaie2 = Monnaie2;
        }


        public void RemplirCombobox(ComboBox combobox)
        {
            InstancierListe();
        }

        private void InstancierListe()
        {
            sListCurrency = new List<List<string>>(23);

            for (int L = 0; L < 8; L++)
            {
                for (int C = 0; C < 8; C++)
                {

                }
            }
        }
    }
}
