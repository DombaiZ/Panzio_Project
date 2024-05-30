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
using System.Windows.Shapes;

namespace Panzio
{
    /// <summary>
    /// Interaction logic for UgyfelAdatok.xaml
    /// </summary>
    public partial class UgyfelAdatok : Window
    {
        
        public UgyfelAdatok()
        {
            InitializeComponent();
        }

        private void Btn_Register_Click(object sender, RoutedEventArgs e)
        {
            string nev = Tbx_UgyfelNev.Text;
            DateTime szuletesiDatum = Dpr_szulEv.SelectedDate.Value;
            string email = Tbx_Email.Text;
            bool vip = Cbx_VIP.IsChecked.Value;

            Ugyfel ugyfel = new Ugyfel(nev, szuletesiDatum, email, vip);
            Adatforras.Ugyfelek.Add(ugyfel);

            MessageBox.Show("Ügyfél sikeresen regisztrálva!");
            Close();
        }

        private void Btn_Vissza_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Tbx_UgyfelNev_TextChanged(object sender, TextChangedEventArgs e)
        {
            string[] nev = Dpr_szulEv.Text.Split('.');
            Tbx_UgyfelID.Text = Tbx_UgyfelNev.Text + nev[0];
        }

        private void Dpr_szulEv_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] nev = Dpr_szulEv.Text.Split('.');
            Tbx_UgyfelID.Text = Tbx_UgyfelNev.Text + nev[0];
        }
    }
}
